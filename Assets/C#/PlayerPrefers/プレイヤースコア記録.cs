using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RankEntry
{
    public string name;
    public int score;
    public float time;
}

public static class RankManager
{
    private const int MaxEntries = 5;

    public static List<RankEntry> LoadEntries()
    {
        List<RankEntry> entries = new List<RankEntry>();

        for (int i = 0; i < MaxEntries; i++)
        {
            string name = PlayerPrefs.GetString("rank_" + i + "_name", "");
        

            if (string.IsNullOrEmpty(name)) continue; 

            int score = PlayerPrefs.GetInt("rank_" + i + "_score", 0);
            float time = PlayerPrefs.GetFloat("rank_" + i + "_time", 0f);
            

            entries.Add(new RankEntry { name = name, score = score, time = time });
            
        }

        return entries;
    }

    public static void AddEntry(string playerName, int score, float time)
    {
        List<RankEntry> entries = LoadEntries();
        entries.Add(new RankEntry { name = playerName, score = score, time = time });
        

        
        
        entries.Sort((a, b) =>
        {
            if (a.time != b.time)
                return a.time.CompareTo(b.time);
            return b.score.CompareTo(a.score);
        });

        if (entries.Count > MaxEntries)
        {
            entries.RemoveRange(MaxEntries, entries.Count - MaxEntries);
        }

        
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

        PlayerPrefs.Save();
    }
}
