using UnityEngine;

public class 墙体生命 : MonoBehaviour
{
    public float hp = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wjzd"))
        {
            hp = hp - 1;
            if (hp <= 0)
            {

                Destroy(gameObject);
            }
        }


    }
}
