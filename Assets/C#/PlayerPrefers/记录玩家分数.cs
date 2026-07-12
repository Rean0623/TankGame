using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RankEntry//一个类 以后可以直接用
{
    public string name;
    public int score;
    public float time;
}

public static class RankManager
{
    private const int MaxEntries = 5;//const为固定值 这样设置后就改不了了 然后为5是设置为最多5条

    public static List<RankEntry> LoadEntries()//这个方法是存储上面那个类对象的 然后LoadEntries是读取出来固定API
    {
        List<RankEntry> entries = new List<RankEntry>();//创建一个空对象 往里面装读取到的记录

        for (int i = 0; i < MaxEntries; i++)//只存5个 0-4
        {
            string name = PlayerPrefs.GetString("rank_" + i + "_name", "");
        //参数1: "rank_" + i + "_name"——这是存储的键名(key),用字符串拼接的方式动态生成
        //比如当 i = 0 时就是 "rank_0_name",i = 1 时是 "rank_1_name"。
        //这样每个排名槽位的名字都存在不同的键下面,不会互相覆盖。
        //参数2: ""——默认值,如果这个key之前从来没存过东西(比如游戏第一次运行, 还没有任何排行记录)
        //就返回这个默认值(空字符串),而不是报错。

            if (string.IsNullOrEmpty(name)) continue; // 没有记录就跳过

            int score = PlayerPrefs.GetInt("rank_" + i + "_score", 0);
            float time = PlayerPrefs.GetFloat("rank_" + i + "_time", 0f);
            //同上 读取分数和时间

            entries.Add(new RankEntry { name = name, score = score, time = time });
            //对象初始化
        }

        return entries;//返回给调用者
    }

    public static void AddEntry(string playerName, int score, float time)//把这一局的新成绩加进排行榜,重新排序,只保留前5名,存回本地。
    {
        List<RankEntry> entries = LoadEntries();//先调用刚才那个方法,把现有的排行榜记录全部读出来。
        entries.Add(new RankEntry { name = playerName, score = score, time = time });
        //把这一局的新成绩,包装成一个新的 RankEntry,加到列表末尾。

        // 时间越短越靠前;时间相同则分数越高越靠前
        //可有可无
        entries.Sort((a, b) =>
        {
            if (a.time != b.time)
                return a.time.CompareTo(b.time);
            return b.score.CompareTo(a.score);
        });

        if (entries.Count > MaxEntries)//如果超了就删除掉
        {
            entries.RemoveRange(MaxEntries, entries.Count - MaxEntries);
        }

        // 先清空所有槽位,再按新顺序重新写入
        for (int i = 0; i < MaxEntries; i++)
        {
            if (i < entries.Count)
            {
                PlayerPrefs.SetString("rank_" + i + "_name", entries[i].name);
                PlayerPrefs.SetInt("rank_" + i + "_score", entries[i].score);
                PlayerPrefs.SetFloat("rank_" + i + "_time", entries[i].time);
            }
            else
            {
                PlayerPrefs.DeleteKey("rank_" + i + "_name");
                PlayerPrefs.DeleteKey("rank_" + i + "_score");
                PlayerPrefs.DeleteKey("rank_" + i + "_time");
            }
        }

        PlayerPrefs.Save();//保存
    }
}
