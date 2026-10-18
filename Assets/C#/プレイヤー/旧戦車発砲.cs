using UnityEngine;

public class 旧戦車発砲 : MonoBehaviour
{
    public float 移动速度 = 10;
    public float 转向速度 = 10;
    public float 炮台转向速度 = 125;

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
        transform.Translate(Vector3.forward * 移动速度 * Time.deltaTime * Input.GetAxis("Vertical"));
        
        transform.Rotate(Vector3.up * 转向速度 * Time.deltaTime * Input.GetAxis("Horizontal"));
        
        head.Rotate(Vector3.up * 炮台转向速度 * Time.deltaTime * Input.GetAxis("Mouse X"));
        


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
            プレイヤー体力 myStatus = GetComponent<プレイヤー体力>();

            GameObject newTank = Instantiate(newTankPrefab, transform.position, transform.rotation);
            

            if (myStatus != null)
            {
                プレイヤー体力 newStatus = newTank.GetComponent<プレイヤー体力>();
                if (newStatus != null)
                {
                    newStatus.SetHpAndShield(myStatus.hp, myStatus.GetMaxHp(), myStatus.GetShieldCount());
                    
                }
            }

            カメラ cam = Camera.main.GetComponent<カメラ>();
            if (cam != null)
            {
                cam.target = newTank.transform;
                
            }

            音楽効果音記録.PlaySFX(weaponSound, transform.position);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
