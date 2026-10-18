using UnityEngine;

public class ホーム設定画面 : MonoBehaviour
{
    public static ホーム設定画面 instance;
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
    public void Awake()
    {
        if(instance != null) 
        {
            Destroy(gameObject);
            return;

        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        nowValue1 = PlayerPrefs.GetFloat("volume", 0.5f);
        nowValue2 = PlayerPrefs.GetFloat("effect", 0.5f);
        is1 = PlayerPrefs.GetInt("is1", 1) == 1;
        is2 = PlayerPrefs.GetInt("is2", 1) == 1;

        HideMe();
    }

    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public Rect rect4;
    public Rect rect5;
    public Rect rect6;
    public Rect rect7;

    public float nowValue1 = 0.5f;
    public float nowValue2 = 0.5f;

    public GUIStyle style1;
    public GUIStyle style2;
    public GUIStyle style3;
    public GUIStyle style4;
    public GUIStyle style5;

    public bool is1 = true;
    public bool is2 = true;

    public AudioSource bgm;

    public void OnGUI()
    {
        GUI.Label(rect1, "ゲーム設定", style1);
        GUI.Label(rect2, "", style2);

        is1 = GUI.Toggle(rect3, is1, "音量", style3);
        PlayerPrefs.SetInt("is1", is1 ? 1 : 0);
        

        nowValue1 = GUI.HorizontalSlider(rect5, nowValue1, 0, 1);
        PlayerPrefs.SetFloat("volume", nowValue1);
        

        if (is1)
            bgm.volume = nowValue1;
        else
            bgm.volume = 0;

        
        is2 = GUI.Toggle(rect4, is2, "効果音", style4);
        PlayerPrefs.SetInt("is2", is2 ? 1 : 0);

        nowValue2 = GUI.HorizontalSlider(rect6, nowValue2, 0, 1);
        PlayerPrefs.SetFloat("effect", nowValue2);

        if (GUI.Button(rect7, "", style5))
        {
            HideMe();
            ホーム画面UI.ShowMe();
        }
    }

}

