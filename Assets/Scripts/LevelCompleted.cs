using UnityEngine;
using System.Collections;

public class LevelCompleted : MonoBehaviour {
    string newSceneName;

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.CompareTag("Player"))
        {
            Application.LoadLevel(newSceneName);
        }
    }
}
