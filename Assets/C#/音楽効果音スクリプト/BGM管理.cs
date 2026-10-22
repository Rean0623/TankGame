using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM管理 : MonoBehaviour
{
    public static BGM管理 instance;

    public AudioClip bgmKaishi;  
    public AudioClip bgmYouxi;   

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
        if (scene.name == "ホームシーン")
        {
            audioSource.clip = bgmKaishi;
        }
        else if (scene.name == "ゲームシーン")
        {
            audioSource.clip = bgmYouxi;
        }

        
        if (ホーム設定画面.instance != null)
        {
            if (ホーム設定画面.instance.is1)
                audioSource.volume = ホーム設定画面.instance.nowValue1;
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
