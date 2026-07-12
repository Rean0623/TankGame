using UnityEngine;

public class 小地图 : MonoBehaviour
{
    public Rect rect1;
    public GUIContent conteng1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnGUI()
    {
        GUI.Label(rect1, conteng1);
    }
}
