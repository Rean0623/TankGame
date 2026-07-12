using UnityEngine;

public class 敌人炮台摆动 : MonoBehaviour
{
    float angle = 0f;      // 当前角度,以正前方为0,范围-45~45
    public float speed = 30f;     // 每秒转动的度数 也就是速度
    int dir = 1;           // 1向右转,-1向左转

    void Update()
    {
        angle += dir * speed * Time.deltaTime;//角度累计

        if (angle >= 45f)
        {
            angle = 45f;
            dir = -1;
        }
        else if (angle <= -45f)
        {
            angle = -45f;
            dir = 1;
        }

        transform.localEulerAngles = new Vector3(0, angle, 0);//相对于父对象为基准的转动
    }

}
