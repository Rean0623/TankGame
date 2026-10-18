using UnityEngine;

public class 敵砲台の揺動 : MonoBehaviour
{
    float angle = 0f;      
    public float speed = 30f;     
    int dir = 1;          

    void Update()
    {
        angle += dir * speed * Time.deltaTime;

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

        transform.localEulerAngles = new Vector3(0, angle, 0);
    }

}
