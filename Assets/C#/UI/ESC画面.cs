using UnityEngine;
using UnityEngine.SceneManagement;

public class ESC画面 : MonoBehaviour
{
    private static ESC画面 instance;
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
        GUI.Label(rect1, "終了確認画面", style1);
        GUI.Label(rect2, "", style2);
        if(GUI.Button(rect3, "はい", style3))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("ホームシーン");
        }
        if(GUI.Button(rect4, "いいえ", style4))
        {
            HideMe();
            Time.timeScale = 1;
            Cursor.lockState=CursorLockMode.Locked;
            Cursor.visible = false;
        }

    }
}
