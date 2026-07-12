using UnityEngine;
using UnityEngine.SceneManagement;

public class 音乐BGM : MonoBehaviour
{
    public static 音乐BGM instance;

    public AudioClip bgmKaishi;   // 拖入 BKMusic1
    public AudioClip bgmYouxi;    // 拖入 BKMusic2

    private AudioSource audioSource;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "kaishijiemian")
        {
            audioSource.clip = bgmKaishi;
        }
        else if (scene.name == "youxijiemian")
        {
            audioSource.clip = bgmYouxi;
        }

        // 从shezhi读取音量
        if (主页的设置界面.instance != null)
        {
            if (主页的设置界面.instance.is1)
                audioSource.volume = 主页的设置界面.instance.nowValue1;
            else
                audioSource.volume = 0;
        }

        audioSource.Play();
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
