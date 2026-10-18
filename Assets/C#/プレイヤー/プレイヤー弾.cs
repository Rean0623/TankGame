using UnityEngine;

public class プレイヤー弾 : MonoBehaviour
{
    public float Speed = 10;

    public AudioClip shootSound;

    void Start()
    {
        
        
            Destroy(gameObject, 0.3f); 
        

        if (shootSound != null)
        {
            音楽効果音記録.PlaySFX(shootSound, transform.position); 
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
