using UnityEngine;

public class 敌人子弹 : MonoBehaviour
{
    public GameObject drdzd;//拖拽预设体敌人子弹
    public Transform drdzdwz;      // 敌人子弹发射位置
    public float fireInterval = 1.5f; // 敌人多久开一炮,自己调
    float timer = 0f;//时间

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireInterval)
        {
            timer = 0f;//以上为经典计时器效果 当过1.5秒后发射一次
            GameObject obj = Instantiate(drdzd.gameObject);//发射预设体
            obj.transform.position = drdzdwz.position;//位置
            obj.transform.rotation = drdzdwz.rotation;//朝向
        }
    }

}
