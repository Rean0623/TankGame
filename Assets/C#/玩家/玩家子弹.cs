using UnityEngine;

public class 玩家子弹 : MonoBehaviour
{
    public float Speed = 10;

    public AudioClip shootSound;

    void Start()
    {
        if (shootSound != null)
        {
            记录音乐和音效.PlaySFX(shootSound, transform.position); // 改这里
        }
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("Ground")) || (other.gameObject.CompareTag("Monster")))
        {
            Destroy(gameObject);
        }
    }
}
