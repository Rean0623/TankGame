using UnityEngine;
public class 音楽効果音記録: MonoBehaviour
{
    
    public static void PlaySFX(AudioClip clip, Vector3 position)
    {
        if (clip == null) return;

        float volume = 1f; 

        if (ホーム設定画面.instance != null)
        {
            volume = ホーム設定画面.instance.is2 ? ホーム設定画面.instance.nowValue2 : 0f;
            
        }

        AudioSource.PlayClipAtPoint(clip, position, volume);
    }
}

