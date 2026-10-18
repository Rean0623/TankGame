using UnityEngine;

public class ミニマップ : MonoBehaviour
{
    public Rect rect1;
    public GUIContent conteng1;
    
    public void OnGUI()
    {
        GUI.Label(rect1, conteng1);
        

    }


}
