using UnityEngine;
using System.Collections;


public class createDominos : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    public GameObject DominoPrefab;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            
            if (Physics.Raycast(ray,out hit))
            {
                Instantiate(DominoPrefab, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
            }
        }

	}
}
