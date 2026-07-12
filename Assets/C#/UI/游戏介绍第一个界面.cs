using UnityEngine;

public class 游戏介绍第一个界面 : MonoBehaviour
{
    
    private static 游戏介绍第一个界面 instance;
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
    public void Start()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
    }
    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public Rect rect4;
    public Rect rect5;
    public Rect rect6;

    public GUIStyle style1;
    public GUIStyle style2;
    public GUIStyle style3;
    public GUIStyle style4;
    public GUIStyle style5;
    public GUIStyle style6;

    public void OnGUI()
    {
        GUI.Label(rect1, "移動と発砲", style1);
        GUI.Label(rect2, "", style2);
        GUI.Label(rect3, "キーボードのWS:前後移動", style3);
        GUI.Label(rect4, "キーボードのAD:方向転換", style4);
        GUI.Label(rect5, "左クリック:発砲", style5);
        if(GUI.Button(rect6, "次のページ", style6))
        {
            HideMe();
            游戏介绍第二个界面.ShowMe();
        }
    }
}
