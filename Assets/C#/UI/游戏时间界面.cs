using UnityEngine;

public class 游戏时间界面 : MonoBehaviour
{
    public static 游戏时间界面 instance; // 新增

    public Rect rect1;
    public Rect rect2;
    public GUIStyle style1;
    public GUIStyle style2;
    private float elapsedTime = 0f;

    private void Awake() // 新增
    {
        instance = this;
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
    }

    public float GetElapsedTime() // 新增
    {
        return elapsedTime;
    }

    public void OnGUI()
    {
        int displaySeconds = Mathf.FloorToInt(elapsedTime);
        GUI.Label(rect1, "ゲーム時間", style1);
        GUI.Label(rect2, displaySeconds + "秒", style2);
    }
}
