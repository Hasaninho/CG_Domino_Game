using UnityEngine;
using System.Collections;

public class pickupDomino : MonoBehaviour 
{
    GameObject mainCamera;
    bool carryingAnObject;
    GameObject carriedObject;
    public float distance;
    public float smooth;
    public float rotateSpeed;
    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (carryingAnObject)
        {
            carry(carriedObject);
            checkDrop();
        }
        else
        {
            pickupObject();
        }
    }

    void carry(GameObject obj)
    {
        //obj.GetComponent<Rigidbody>().isKinematic = true;
        obj.GetComponent<Rigidbody>().detectCollisions = false;
        obj.transform.position = Vector3.Lerp(obj.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
        if (Input.GetKey(KeyCode.Q)) {
            obj.transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            obj.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            obj.transform.Rotate(Vector3.back, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            obj.transform.Rotate(Vector3.back, -rotateSpeed * Time.deltaTime);
        }
    }

    void pickupObject()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            
            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
            
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                pickable p = hit.collider.GetComponent<pickable>();
                if (p != null)
                {
                    p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    
                    carryingAnObject = true;
                    carriedObject = p.gameObject;

                }
            }
        }
    }

    void checkDrop()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carryingAnObject = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().detectCollisions = true;
        carriedObject = null; 
    }
}
