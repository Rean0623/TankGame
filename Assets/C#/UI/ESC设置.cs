using UnityEngine;

public class ESC设置 : MonoBehaviour
{
    private static ESC设置 instance;
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
            ESC界面.ShowMe();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
