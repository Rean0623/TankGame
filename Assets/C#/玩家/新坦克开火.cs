using UnityEngine;

public class 新坦克开火 : MonoBehaviour
{
    public float a = 10;
    public float b = 10;
    public float c = 125;
    public float d = 100;
    public Transform head;
    public Transform kou;
    public GameObject zidan1;
    public GameObject zidan2;
    public GameObject zidan3;
    public Transform zidanweizhi1;
    public Transform zidanweizhi2;
    public Transform zidanweizhi3;

    void Start()
    {

    }

    void Update()
    {
        if (Time.timeScale == 0) return; // 加这一行,暂停时不执行

        transform.Translate(Vector3.forward * a * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(Vector3.up * b * Time.deltaTime * Input.GetAxis("Horizontal"));
        head.Rotate(Vector3.up * c * Time.deltaTime * Input.GetAxis("Mouse X"));

        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj1 = Instantiate(zidan1);
            obj1.transform.position = zidanweizhi1.position;
            obj1.transform.rotation = zidanweizhi1.rotation;
            GameObject obj2 = Instantiate(zidan2);
            obj2.transform.position = zidanweizhi2.position;
            obj2.transform.rotation = zidanweizhi2.rotation;
            GameObject obj3 = Instantiate(zidan3);
            obj3.transform.position = zidanweizhi3.position;
            obj3.transform.rotation = zidanweizhi3.rotation;
        }
    }
}
