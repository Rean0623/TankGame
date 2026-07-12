using UnityEngine;

public class 游戏开始界面的物体红塔炮台 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
    }
}
