﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

    public GameObject ball;
	//public string nextScene;
    public GameObject door;

    private void OnTriggerEnter(Collider enteredObj)
    {
        
        if (ball == enteredObj.gameObject)
        {

            //yield return new WaitForSecondsRealtime(5);
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(5);
        door.SetActive(true);
		//SceneManager.LoadScene(nextScene/*SceneManager.GetActiveScene().name*/, LoadSceneMode.Single);
        

    }
}
