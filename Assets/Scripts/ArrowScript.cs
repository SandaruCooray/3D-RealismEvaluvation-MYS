using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;


    public int damageAmount = 20;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        Destroy(gameObject,2);
    }

    /*

    private void OnTriggerEnter(Collider other)
    {
        // Log the name of the object the arrow hits
        Debug.Log("Arrow hit: " + other.gameObject.name);

    

        Destroy(transform.GetComponent<Rigidbody>());
    }

    */

    private void OnTriggerEnter(Collider other)
    {
        // Log the name of the object the arrow hits
        Debug.Log("Arrow hit: " + other.gameObject.name);

        if(other.tag == "nightdragon")
        {

            transform.parent = other.transform;
            other.GetComponent<DragonController>().TakeDamage(damageAmount);
        }

        //Rigidbody rb = transform.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }
}
