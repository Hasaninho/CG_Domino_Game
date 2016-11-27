using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {

    public Canvas MenuCanvas;

	void Awake()
    {
        MenuCanvas.enabled = true;
    }
}
