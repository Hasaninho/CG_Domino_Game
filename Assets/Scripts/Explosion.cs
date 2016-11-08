using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    public GameObject ball;
    public float explosionRadius = 5.5f;
    private Collider[] hitColliders;
    public float explosionsPower = 10.0f;
    public LayerMask expliosionLayers;
    public float explosionUpPressure = 1.0f;

    public void OnTriggerEnter(Collider enteredBall)
    {
        if(ball == enteredBall.gameObject)
        {
            Vector3 explosionPoint = ball.transform.position;

            hitColliders = Physics.OverlapSphere(explosionPoint, this.explosionRadius);

            foreach(Collider hitColl in hitColliders)
            {
                if (hitColl.GetComponent<Rigidbody>() != null)
                {
                    hitColl.GetComponent<Rigidbody>().isKinematic = false;
                    hitColl.GetComponent<Rigidbody>().AddExplosionForce(explosionsPower, explosionPoint, explosionRadius, explosionUpPressure, ForceMode.Impulse);
                }
            }
        }
    }
}
