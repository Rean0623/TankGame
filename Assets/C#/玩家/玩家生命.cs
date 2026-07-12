using UnityEngine;

public class 玩家生命 : MonoBehaviour
{
    private static 玩家生命 instance;
    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
        }
    }
    public static void HideMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(false);
        }
    }
    private void Awake()
    {
        instance = this;
    }
    public float hp = 3;
    private float maxHp;
    private bool maxHpInitialized = false;

    public Texture2D bgTexture;
    public Texture2D fillTexture;
    public Texture2D iconTexture;

    public Texture2D shieldIconTexture;
    private int shieldCount = 0;

    public AudioClip healSound;
    public AudioClip shieldSound;

    void Start()
    {
        if (!maxHpInitialized)
        {
            maxHp = hp;
            maxHpInitialized = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HealItem"))
        {
            hp = hp + 2;
            if (hp > maxHp) hp = maxHp;

            记录音乐和音效.PlaySFX(healSound, transform.position);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("ShieldItem"))
        {
            shieldCount = shieldCount + 1;

            记录音乐和音效.PlaySFX(shieldSound, transform.position);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("EnemyBullet"))
        {
            if (shieldCount > 0)
            {
                shieldCount = shieldCount - 1;
            }
            else
            {
                hp = hp - 1;
                if (hp <= 0)
                {
                    Time.timeScale = 0;
                    游戏失败界面.ShowMe();
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
        }
        else if (other.CompareTag("tgd"))
        {
            Time.timeScale = 0;
            游戏通关页面.ShowMe();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void SetHpAndShield(float newHp, float newMaxHp, int newShieldCount)
    {
        hp = newHp;
        maxHp = newMaxHp;
        maxHpInitialized = true;
        shieldCount = newShieldCount;
    }

    public float GetMaxHp()
    {
        return maxHp;
    }

    public int GetShieldCount()
    {
        return shieldCount;
    }

    void OnGUI()
    {
        float barWidth = 500;
        float barHeight = 50;
        float margin = 20;
        float iconSize = 100;
        float spacing = 10;

        float iconX = margin;
        float iconY = Screen.height - iconSize - margin;

        float barX = iconX + iconSize + spacing;
        float barY = Screen.height - barHeight - margin - (iconSize - barHeight) / 2f;

        GUI.DrawTexture(new Rect(iconX, iconY, iconSize, iconSize), iconTexture);
        GUI.DrawTexture(new Rect(barX, barY, barWidth, barHeight), bgTexture);

        float hpPercent = Mathf.Clamp01(hp / maxHp);
        float fillWidth = barWidth * hpPercent;
        if (fillWidth > 0)
        {
            GUI.DrawTexture(new Rect(barX, barY, fillWidth, barHeight), fillTexture);
        }

        float shieldIconSize = 100;
        float shieldSpacing = 5;
        float shieldStartX = barX + barWidth + spacing;

        for (int i = 0; i < shieldCount; i++)
        {
            float shieldX = shieldStartX + i * (shieldIconSize + shieldSpacing);
            float shieldY = barY + (barHeight - shieldIconSize) / 2f;
            GUI.DrawTexture(new Rect(shieldX, shieldY, shieldIconSize, shieldIconSize), shieldIconTexture);
        }
    }
}
