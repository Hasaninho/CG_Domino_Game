using UnityEngine;
using System.Collections;

public class GoToScene : MonoBehaviour {

	// Use this for initialization
	public void NextLevelButton (int index)
    {
        Application.LoadLevel(index);
	}

    // Update is called once per frame
    public void NextLevelButton(string levelName)
    {
        Application.LoadLevel(levelName);
    }
}
