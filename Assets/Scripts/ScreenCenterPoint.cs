using UnityEngine;
using System.Collections;

public class ScreenCenterPoint : MonoBehaviour {

    // Use this for initialization
    public Texture texPoint;
    
    void OnGUI()
    {
        if (!texPoint)
        {
            print("no Texture!!");
            return;
        }
        GUI.DrawTexture(new Rect(Screen.width / 2, Screen.height / 2, 3, 3), texPoint);//, ScaleMode.ScaleAndCrop, true, 10.0F);
    }
}
