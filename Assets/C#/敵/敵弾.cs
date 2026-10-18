using UnityEngine;

public class 敵弾 : MonoBehaviour
{
    public GameObject drdzd;
    public Transform drdzdwz;      
    public float fireInterval = 1.5f; 
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireInterval)
        {
            timer = 0f;
            GameObject obj = Instantiate(drdzd.gameObject);
            obj.transform.position = drdzdwz.position;
            obj.transform.rotation = drdzdwz.rotation;
        }
    }

}
