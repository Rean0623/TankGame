using UnityEngine;

public class 壁の耐久値 : MonoBehaviour
{
    public float hp = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            hp = hp - 1;
            if (hp <= 0)
            {

                Destroy(gameObject);
            }
        }


    }
}
