using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour
{
    public void exitMethod()
	{
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
