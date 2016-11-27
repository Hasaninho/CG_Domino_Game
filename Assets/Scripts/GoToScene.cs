using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {
    //int idx = 0;
	// Use this for initialization
	public void NextLevelButton (int idx)
    {
        //Application.LoadLevel(index);
        idx = (idx % 5) + 2;
        SceneManager.LoadScene(idx);
        idx++;
	}

    // Update is called once per frame
    public void NextLevelButton(string nextScene)
    {
        SceneManager.LoadScene(nextScene/*SceneManager.GetActiveScene().name*/, LoadSceneMode.Single);
    }
}
