using UnityEngine;
using System.Collections;

public class tilt : MonoBehaviour {

    private Rigidbody rb;
    public int strength;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

        //rb.AddForce(new Vector3(1.0f, 0.0f, 0.0f));
        //rb.AddForceAtPosition();
        
	}
    
    void OnMouseDown()
    {
        rb.AddForce(-transform.right * strength);
    }
    
    //void FixedUpdate()
    //{
    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        Domino001.rigidbody.AddForceAtPosition(domino.transform.right * 30.0f, domino.transform.position + new Vector3(0, 5.0f, 0));
    //    }
    //}

    ////Update is called once per frame
    //void Update()
    //{

    //}
}
