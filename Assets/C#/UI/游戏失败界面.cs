using UnityEngine;
using UnityEngine.SceneManagement;

public class 游戏失败界面 : MonoBehaviour
{
    private static 游戏失败界面 instance;
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

    public GUIStyle style1;
    public GUIStyle style2;
    public GUIStyle style3;
    public GUIStyle style4;
    public void OnGUI()
    {
        GUI.Label(rect1, "ゲームオーバー", style1);
        GUI.Label(rect2, "残念、戦車は破壊された", style2);
        if(GUI.Button(rect3, "もう一度挑戦する", style3))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("youxijiemian");
        }
        if(GUI.Button(rect4, "スタート画面に戻る", style4))
        {
            SceneManager.LoadScene("kaishijiemian");
        }
    }
}
