using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{

    private float velocity;
    private Vector3 direction;
    // Use this for initialization
    void Start()
    {
        velocity = 3f;
        direction = new Vector3(1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction*velocity*Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D collided)
    {
        var pedal = collided.gameObject.GetComponent<PedalController>();
        var wall = collided.gameObject.CompareTag("Wall");
        if (pedal)
        {
            direction = new Vector3(-direction.x, direction.y, direction.z);
            Debug.Log("Collided with " + pedal);
        }
        

        if (wall)
        {
            direction = new Vector3(direction.x, -direction.y, direction.z);
            Debug.Log("Collided with " + wall);
        }
         
    }
}

