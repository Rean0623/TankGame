using UnityEngine;

public class 音效 : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        if (主页的设置界面.instance != null)
        {
            audioSource.volume = 主页的设置界面.instance.is2 ? 主页的设置界面.instance.nowValue2 : 0f;
        }
    }
}
