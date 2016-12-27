using UnityEngine;
using System.Collections;
using System;

public class createDominos : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    public GameObject DominoPrefab;
    public Camera mainCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (mainCamera.isActiveAndEnabled) { 
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                if (Physics.Raycast(ray, out hit))
                {
                    Instantiate(DominoPrefab, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
                }
            }
        }

	}
}
