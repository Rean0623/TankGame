using UnityEngine;

public class 敌人移动脚本 : MonoBehaviour
{
    public float speed = 3f;//移动
    private int dir = 1;// 控制方向 看前面是什么right的话，1就是正常right，-1就是反方向left
    private bool canFlip = true;

    void Update()
    {
        transform.Translate(Vector3.right * dir * speed * Time.deltaTime);
        //参数分别为 向右 正反 速度 时间
    }

    void OnCollisionEnter(Collision collision)//物体碰撞的时候，被子弹什么的集中也算，
                                              //所以如果要写移动的话最好加一个tag
    {
        if (canFlip)//防止抖动，如果不加可能没有转向，也就是一次判定
        {
            dir = -dir;//反方向
            canFlip = false;//变负 等为正 目前不允许转向
            Invoke("ResetFlip", 0.5f);//0，5秒后调用ResetFilp这个方法 然后才能转向
        }
    }

    void ResetFlip()
    {
        canFlip = true;
    }
}
