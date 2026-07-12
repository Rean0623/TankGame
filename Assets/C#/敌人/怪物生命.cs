using UnityEngine;

public class 怪物生命 : MonoBehaviour
{
    public Rigidbody body;
    public float hp = 3;
    public GameObject deathEffectPrefab; // 拖入UnitDestroyedEffect预制体
    public Texture2D bgTexture;    // 血条背景图(拖拽赋值)
    public Texture2D fillTexture;  // 血条填充图(拖拽赋值)
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

        // 画背景图
        GUI.DrawTexture(new Rect(x, y, barWidth, barHeight), bgTexture);

        // 画填充图(按血量比例裁剪宽度)
        float hpPercent = Mathf.Clamp01(hp / maxHp);
        float fillWidth = barWidth * hpPercent;

        if (fillWidth > 0)
        {
            // 用GUI.DrawTexture的重载,可以指定纹理的裁剪区域(UV)
            Rect fillRect = new Rect(x, y, fillWidth, barHeight);
            Rect texCoord = new Rect(0, 0, hpPercent, 1); // 只取纹理左边hpPercent那部分
            GUI.DrawTexture(fillRect, fillTexture, ScaleMode.StretchToFill, true, 0, Color.white, 0, 0);
        }
    }
        // 如果想更精确按UV裁剪,用下面这

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wjzd"))
        {
            hp = hp - 1;
            if (hp <= 0)
            {
                Instantiate(deathEffectPrefab, transform.position, transform.rotation);
                if (游戏分数界面.instance != null)
                {
                    游戏分数界面.instance.AddScore(10);
                }
                Destroy(gameObject);
            }
        }
    }
}