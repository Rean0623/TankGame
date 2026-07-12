using UnityEngine;
using System.Collections.Generic;

public class 排行榜 : MonoBehaviour
{
    private static 排行榜 instance;
    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
            instance.RefreshData(); // 每次显示时重新读取最新数据
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
    public Rect rect12;
    public Rect rect13;
    public Rect rect14;
    public Rect rect15;
    public Rect rect16;
    public Rect rect17;
    public Rect rect18;
    public Rect rect19;
    public Rect rect20;
    public Rect rect21;
    public Rect rect22;
    public Rect rect23;
    public Rect rect24;
    public Rect rect25;
    public Rect rect26;
    public Rect rect27;

    public GUIStyle style1;
    public GUIStyle style2;
    public GUIStyle style3;

    public GUIStyle style4;
    public GUIStyle style5;
    public GUIStyle style6;
    public GUIStyle style7;
    public GUIStyle style8;
    public GUIStyle style9;
    public GUIStyle style10;
    public GUIStyle style11;
    public GUIStyle style12;
    public GUIStyle style13;
    public GUIStyle style14;
    public GUIStyle style15;
    public GUIStyle style16;
    public GUIStyle style17;
    public GUIStyle style18;
    public GUIStyle style19;
    public GUIStyle style20;
    public GUIStyle style21;
    public GUIStyle style22;
    public GUIStyle style23;
    public GUIStyle style24;
    public GUIStyle style25;
    public GUIStyle style26;
    public GUIStyle style27;

    private List<RankEntry> entries = new List<RankEntry>();

    void RefreshData()
    {
        entries = RankManager.LoadEntries();
    }

    string GetName(int index)
    {
        if (index < entries.Count) return entries[index].name;
        return "空席";
    }

    string GetScore(int index)
    {
        if (index < entries.Count) return entries[index].score.ToString();
        return "0";
    }

    string GetTime(int index)
    {
        if (index < entries.Count) return Mathf.FloorToInt(entries[index].time) + "秒";
        return "0秒";
    }

    public void OnGUI()
    {
        GUI.Label(rect1, "ランキング", style1);
        GUI.Label(rect2, "", style2);
        if (GUI.Button(rect3, "", style3))
        {
            HideMe();
            主页的UI.ShowMe();
        }

        GUI.Label(rect4, "順位", style4);
        GUI.Label(rect5, "プレイヤー名", style5);
        GUI.Label(rect6, "スコア", style6);
        GUI.Label(rect7, "ゲーム時間", style7);

        GUI.Label(rect8, "第1位", style8);
        GUI.Label(rect9, GetName(0), style9);
        GUI.Label(rect10, GetScore(0), style10);
        GUI.Label(rect11, GetTime(0), style11);

        GUI.Label(rect12, "第2位", style12);
        GUI.Label(rect13, GetName(1), style13);
        GUI.Label(rect14, GetScore(1), style14);
        GUI.Label(rect15, GetTime(1), style15);

        GUI.Label(rect16, "第3位", style16);
        GUI.Label(rect17, GetName(2), style17);
        GUI.Label(rect18, GetScore(2), style18);
        GUI.Label(rect19, GetTime(2), style19);

        GUI.Label(rect20, "第4位", style20);
        GUI.Label(rect21, GetName(3), style21);
        GUI.Label(rect22, GetScore(3), style22);
        GUI.Label(rect23, GetTime(3), style23);

        GUI.Label(rect24, "第5位", style24);
        GUI.Label(rect25, GetName(4), style25);
        GUI.Label(rect26, GetScore(4), style26);
        GUI.Label(rect27, GetTime(4), style27);
    }
}
