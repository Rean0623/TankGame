using UnityEngine;
using UnityEngine.SceneManagement;

public class 主页的UI : MonoBehaviour
{
    private static 主页的UI instance;
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

    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public Rect rect4;
    public Rect rect5;
    
    
    public GUIStyle style1;
    public GUIStyle style2;
    public GUIStyle style3;
    public GUIStyle style4;
    public GUIStyle style5;
    
    
    private void OnGUI()
    {
        GUI.Label(rect1, "タンクバトル", style1);
       if( GUI.Button(rect2, "ゲームを始める", style2))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("youxijiemian");
        }
       if( GUI.Button(rect3, "設定", style3))
        {
            主页的设置界面.ShowMe();
            HideMe();
        }
       if( GUI.Button(rect4, "ゲーム終了", style4))
        {
            Application.Quit();
        }
        if (GUI.Button(rect5, "ランキング", style5))
        {
            排行榜.ShowMe();
            HideMe();
        }
        
       






    }
}
