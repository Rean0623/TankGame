using UnityEngine;

public class 強力な敵弾 : MonoBehaviour
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

            float[] angles = { -45f, 0f, 45f }; 

            foreach (float angle in angles)
            {
                GameObject obj = Instantiate(drdzd.gameObject);
                obj.transform.position = drdzdwz.position;
                obj.transform.rotation = drdzdwz.rotation * Quaternion.Euler(0, angle, 0);
            }
        }
    }
}
