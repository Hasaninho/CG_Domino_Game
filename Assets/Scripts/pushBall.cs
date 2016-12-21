using UnityEngine;
using System.Collections;

public class pushBall : MonoBehaviour
{

    private Rigidbody rb;
    public int strength;
    public GameObject domino;
    public string direction = "Red";
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //rb.AddForce(new Vector3(1.0f, 0.0f, 0.0f));
        //rb.AddForceAtPosition();

    }

    void OnCollisionEnter(Collision col)
    {
        if(domino == col.gameObject)
        { 
            if(direction == "Red")
            {
                rb.AddForce(-transform.right * strength);
            }else if(direction == "Blue")
            {
                rb.AddForce(-transform.forward * strength);
            }else if(direction == "Green")
            {
                rb.AddForce(-transform.up * strength);
            }
            
        }
    }
    //Update is called once per frame
    //void Update()
    //{

    //}
}
