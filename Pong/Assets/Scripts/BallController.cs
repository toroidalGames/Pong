using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{

    private float velocity;
    private Vector3 direction;
	// Use this for initialization
	void Start ()
	{
	    velocity = 2f;
	    direction = new Vector3(1,1,0);
    }   
	
	// Update is called once per frame
	void Update ()
	{
	    transform.position = transform.position+direction*velocity*Time.deltaTime ;
	}
}
