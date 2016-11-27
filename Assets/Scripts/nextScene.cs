using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{

    
    public string nextSceneName;

    private void OnTriggerEnter(Collider enteredObj)
    {
        //print("hi " + enteredObj.ToString() + " Tag " + enteredObj.tag.ToString() );

        //if (enteredObj.tag == "Player")
        //{
            SceneManager.LoadScene(nextSceneName/*SceneManager.GetActiveScene().name*/, LoadSceneMode.Single);
        //}
    }
}
