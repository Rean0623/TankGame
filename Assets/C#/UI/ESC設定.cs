using UnityEngine;

public class ESC設定 : MonoBehaviour
{
    private static ESC設定 instance;
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
    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            ESC画面.ShowMe();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
