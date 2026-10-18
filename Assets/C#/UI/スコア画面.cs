using UnityEngine;

public class スコア画面 : MonoBehaviour
{
    public static スコア画面 instance;
    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public Texture texture1;
    public GUIStyle style1;
    public GUIStyle style2;
    public GUIStyle style3;
    public int score = 0;
    private void Awake()
    {
        instance = this;
    }
    public void AddScore(int amount)
    {
        score += amount;
    }
    
    public void OnGUI()
    {
        GUI.Label(rect1, "スコア", style1);
        GUI.Label(rect2, score.ToString(), style2);
        GUI.Label(rect3, texture1, style3);
    }
}
