using UnityEngine;

public class 敵移動スクリプト : MonoBehaviour
{
    public float speed = 3f;
    private int dir = 1;
    private bool canFlip = true;

    void Update()
    {
        transform.Translate(Vector3.right * dir * speed * Time.deltaTime);
       
    }

    void OnCollisionEnter(Collision collision)
    {
        if (canFlip)
        {
            dir = -dir;
            canFlip = false;
            Invoke("ResetFlip", 0.5f);
        }
    }

    void ResetFlip()
    {
        canFlip = true;
    }
}
