using UnityEngine;

public class タイム画面 : MonoBehaviour
{
    public static タイム画面 instance; 

    public Rect rect1;
    public Rect rect2;
    public GUIStyle style1;
    public GUIStyle style2;
    private float elapsedTime = 0f;

    private void Awake() 
    {
        instance = this;
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
    }

    public float GetElapsedTime() 
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
