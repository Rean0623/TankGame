using UnityEngine;
using UnityEngine.UIElements;

public class モンスターの体力 : MonoBehaviour
{
    public Rigidbody body;
    public float hp = 3;
    public GameObject deathEffectPrefab; 
    public Texture2D bgTexture;    
    public Texture2D fillTexture; 
    public float maxHp = 3;

    void OnGUI()
    {
        if (Time.timeScale == 0) return;
        if (hp >= maxHp)
            return;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position + Vector3.up * 1.5f);
        
        if (screenPos.z < 0) return;
        

        float guiY = Screen.height - screenPos.y;
        float barWidth = 200;
        float barHeight = 8;
        float x = screenPos.x - barWidth / 2;
        float y = guiY;
     

        
        GUI.DrawTexture(new Rect(x, y, barWidth, barHeight), bgTexture);

        
        float hpPercent = Mathf.Clamp01(hp / maxHp);
        
        float fillWidth = barWidth * hpPercent;
        
        if (fillWidth > 0)
        {
           
            Rect fillRect = new Rect(x, y, fillWidth, barHeight);
            Rect texCoord = new Rect(0, 0, hpPercent, 1); 
            GUI.DrawTexture(fillRect, fillTexture, ScaleMode.StretchToFill, true, 0, Color.white, 0, 0);
        }
    }
        

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            hp = hp - 1;
            if (hp <= 0)
            {
                Instantiate(deathEffectPrefab, transform.position, transform.rotation);
                if (スコア画面.instance != null)
                {
                    スコア画面.instance.AddScore(10);
                }
                Destroy(gameObject);
            }
        }
    }
}