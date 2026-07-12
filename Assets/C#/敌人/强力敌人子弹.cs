using UnityEngine;

public class 强力敌人子弹 : MonoBehaviour
{
    public GameObject drdzd;        // 敌人子弹预制体
    public Transform drdzdwz;       // 敌人子弹发射位置
    public float fireInterval = 1.5f; // 敌人多久开一炮,自己调
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireInterval)
        {
            timer = 0f;

            float[] angles = { -45f, 0f, 45f }; // 三个发射角度

            foreach (float angle in angles)
            {
                GameObject obj = Instantiate(drdzd.gameObject);
                obj.transform.position = drdzdwz.position;
                obj.transform.rotation = drdzdwz.rotation * Quaternion.Euler(0, angle, 0);
            }
        }
    }
}
