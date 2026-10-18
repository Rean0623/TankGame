using UnityEngine;

public class ゲーム開始画面の赤色砲台 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
    }
}
