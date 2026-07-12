using UnityEngine;

public class 旧坦克开火 : MonoBehaviour
{
    public float a = 10;
    public float b = 10;
    public float c = 125;
    public float d = 100;
    public Transform head;
    public Transform kou;
    public GameObject zidan;
    public Transform zidanweizhi;

    public GameObject newTankPrefab;
    public AudioClip weaponSound;

    void Start()
    {

    }

    void Update()
    {
        if (Time.timeScale == 0) return;
        transform.Translate(Vector3.forward * a * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(Vector3.up * b * Time.deltaTime * Input.GetAxis("Horizontal"));
        head.Rotate(Vector3.up * c * Time.deltaTime * Input.GetAxis("Mouse X"));

        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(zidan);
            obj.transform.position = zidanweizhi.position;
            obj.transform.rotation = zidanweizhi.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WeaponItem"))
        {
            玩家生命 myStatus = GetComponent<玩家生命>();

            GameObject newTank = Instantiate(newTankPrefab, transform.position, transform.rotation);

            if (myStatus != null)
            {
                玩家生命 newStatus = newTank.GetComponent<玩家生命>();
                if (newStatus != null)
                {
                    newStatus.SetHpAndShield(myStatus.hp, myStatus.GetMaxHp(), myStatus.GetShieldCount());
                }
            }

            摄像机 cam = Camera.main.GetComponent<摄像机>();
            if (cam != null)
            {
                cam.target = newTank.transform;
            }

            记录音乐和音效.PlaySFX(weaponSound, transform.position);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
