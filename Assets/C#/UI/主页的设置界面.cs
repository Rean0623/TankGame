using UnityEngine;

public class 主页的设置界面 : MonoBehaviour
{
    public static 主页的设置界面 instance;
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
        is1 = PlayerPrefs.GetInt("is1", 1) == 1;//用数据存储的情况下写 PlayerPrefs没有bool这种写法只能这样写bool
                                                //代码的意思就是当is1为1 然后又等于1所以为true
                                                //想写false可以让第一个那个1写成0就行了
                                                //意思为is1为0不等1所以为false
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
        //不用三元表达式就这么写
        //bool newIs1 = GUI.Toggle(rect3, is1, "音量", style3);
        //if (newIs1 != is1)
        //{
        //    is1 = newIs1;
        //    if (is1)
        //    {
        //        PlayerPrefs.SetInt("is1", 1);
        //    }
        //    else
        //    {
        //        PlayerPrefs.SetInt("is1", 0);
        //    }
        //}

        nowValue1 = GUI.HorizontalSlider(rect5, nowValue1, 0, 1);
        PlayerPrefs.SetFloat("volume", nowValue1);
        //上面不用三元这里也得改
        //float newValue1 = GUI.HorizontalSlider(rect5, nowValue1, 0, 1); // 0 和 1 是滑条的最小/最大范围。
                                                                         //返回值是这一帧滑块实际所在的数值
                                                                        //先存进新变量 newValue1,不直接覆盖旧值。
        //if (newValue1 != nowValue1)
        //{
        //    nowValue1 = newValue1;
        //    PlayerPrefs.SetFloat("volume", nowValue1);  //让volume等于滑动条的新值
        //}

        if (is1)
            bgm.volume = nowValue1;//这个可以点出来的volume是自带的api是调节这个音源的大小的
        else
            bgm.volume = 0;

        //下面的音效和上面的音乐一样逻辑
        is2 = GUI.Toggle(rect4, is2, "音効", style4);
        PlayerPrefs.SetInt("is2", is2 ? 1 : 0);

        nowValue2 = GUI.HorizontalSlider(rect6, nowValue2, 0, 1);
        PlayerPrefs.SetFloat("effect", nowValue2);

        if (GUI.Button(rect7, "", style5))
        {
            HideMe();
            主页的UI.ShowMe();
        }
    }

}

