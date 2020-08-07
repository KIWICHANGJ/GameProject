using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EAT : MonoBehaviour {

    public GameObject player;
    public Vector3 V3_random;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        V3_random = new Vector3(Random.Range(4.0f, -4.0f), 0.5f, Random.Range(4.0f, -4.0f));
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = new Vector3((float)0, (float)0, (float)0);
            gameObject.transform.position = V3_random;
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    
}

