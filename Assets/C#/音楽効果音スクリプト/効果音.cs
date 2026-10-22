using UnityEngine;

public class 効果音 : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        if (ホーム設定画面.instance != null)
        {
            audioSource.volume = ホーム設定画面.instance.is2 ? ホーム設定画面.instance.nowValue2 : 0f;
        }
    }
}
