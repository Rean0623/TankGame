using UnityEngine;

public class ゲーム説明第三画面 : MonoBehaviour
{
    private static ゲーム説明第三画面 instance;
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

    public Texture texture3;
    public Texture texture4;
    public Texture texture5;

    public GUIStyle style1;
    public GUIStyle style2;
    public GUIStyle style6;
    public GUIStyle style7;
    public GUIStyle style8;
    public GUIStyle style9;
    public void OnGUI()
    {
        GUI.Label(rect1, "シーンと敵", style1);
        GUI.Label(rect2, "", style2);
        GUI.Label(rect3, texture3);
        GUI.Label(rect4, texture4);
        GUI.Label(rect5, texture5);
        GUI.Label(rect6, "破壊可能のシーン", style6);
        GUI.Label(rect7, "破壊不可能のシーン", style7);
        GUI.Label(rect8, "赤い物は全て敵です", style8);
        if(GUI.Button(rect9, "OK!", style9))
        {
            HideMe();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
            
        }

        
    }
}
