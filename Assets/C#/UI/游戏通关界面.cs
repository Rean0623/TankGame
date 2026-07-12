using UnityEngine;
using UnityEngine.SceneManagement;

public class 游戏通关页面 : MonoBehaviour
{
    private static 游戏通关页面 instance;
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

    private string inputStr = "";
    public void OnGUI()
    {
        GUI.Label(rect1, "クリアおめでとう!", style1);
        GUI.Label(rect2, "ユーザー名を入力してください", style2);
        inputStr = GUI.TextField(rect3, inputStr, style3);
        if (GUI.Button(rect4, "決定", style4))
        {
            int score = 游戏分数界面.instance != null ? 游戏分数界面.instance.score : 0;
            float time = 游戏时间界面.instance != null ? 游戏时间界面.instance.GetElapsedTime() : 0f;

            string finalName = string.IsNullOrEmpty(inputStr) ? "名無し" : inputStr;
            RankManager.AddEntry(finalName, score, time); // 保存这次成绩

            Time.timeScale = 1;
            SceneManager.LoadScene("kaishijiemian");
        }
    }
}
