using UnityEngine;

public class 游戏介绍第二个界面 : MonoBehaviour
{
    private static 游戏介绍第二个界面 instance;
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
        HideMe();
    }
    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public Rect rect4;
    public Rect rect5;
    public Rect rect6;
    public Rect rect7;
    public Rect rect8;
    public Rect rect9;
    public Rect rect10;
    public Rect rect11;

    public Texture texture3;
    public Texture texture4;
    public Texture texture5;
    public Texture texture6;

    public GUIStyle style1;
    public GUIStyle style2;
    public GUIStyle style7;
    public GUIStyle style8;
    public GUIStyle style9;
    public GUIStyle style10;
    public GUIStyle style11;
    public void OnGUI()
    {
        GUI.Label(rect1, "シーンとアイテム", style1);
        GUI.Label(rect2, "", style2);
        GUI.Label(rect3, texture3);
        GUI.Label(rect4, texture4);
        GUI.Label(rect5, texture5);
        GUI.Label(rect6, texture6);
        GUI.Label(rect7, "HP回復", style7);
        GUI.Label(rect8, "攻撃を一回に防ぐ", style8);
        GUI.Label(rect9, "強いの武器変更", style9);
        GUI.Label(rect10, "ゴール地点", style10);
        if(GUI.Button(rect11, "次のページ", style11))
        {
            HideMe();
            游戏介绍第三个界面.ShowMe();
        }
    }
}
