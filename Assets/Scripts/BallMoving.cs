using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviour
{
    [SerializeField]
    public float floSpeed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float floX = Input.GetAxis("Horizontal");
	    float floY = Input.GetAxis("Vertical");
	    if (floX > 0)
	    {
	        gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * floSpeed;
	    }
	    else if(floX < 0)
	    {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.left * floSpeed;
        }

	    if (floY > 0)
	    {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * floSpeed;
        }
	    else if(floY < 0)
	    {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.back * floSpeed;
        }
	}
}
