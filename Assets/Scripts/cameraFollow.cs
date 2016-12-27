using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
    public Camera mainCam;
    public Camera followCamera;
    public float x = 0;
    public float y = 0;
    public float z = 0;
    bool activFlag = true;
    // Use this for initialization
    void Start () {
        followCamera.enabled = false;
        mainCam.enabled = true;
	}

    
 
    void  OnMouseUp()
    {
        followCamera.enabled = true;
        mainCam.enabled = false;
        followCamera.transform.position = new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z + z);
    }

    void OnCollisionEnter(Collision col)
    {
        if (followCamera.isActiveAndEnabled)
        {
            if (col.gameObject.tag != "terrain" && activFlag)
            {
                activFlag = false;
                followCamera.transform.position = new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z + z );
                //followCamera.transform.position = new Vector3( transform.position.x - 2.5f, transform.position.y + 1.1f, col.transform.position.z);
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
