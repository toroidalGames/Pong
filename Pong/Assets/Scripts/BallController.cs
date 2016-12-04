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
        if (pedal && direction.x == 1f && direction.y == 1f)
        {
            direction = new Vector3(-1, 1, 0);
            Debug.Log("Collided with " + pedal);
        }
        else if (pedal && direction.x == -1f && direction.y == -1f)
        {
            direction = new Vector3(1, -1, 0);
            Debug.Log("Collided with " + pedal);
        }
        else if (pedal && direction.x == -1f && direction.y == 1f)
        {
            direction = new Vector3(1, 1, 0);
            Debug.Log("Collided with " + wall);
        }
        else if (pedal && direction.x == 1f && direction.y == -1f)
        {
            direction = new Vector3(-1, -1, 0);
            Debug.Log("Collided with " + wall);
        }


        if (wall && direction.x == -1f && direction.y == 1f)
            {
                direction = new Vector3(-1, -1, 0);
                Debug.Log("Collided with " + wall);
            }
            else if (wall && direction.x == 1f && direction.y == -1f)
            {
                direction = new Vector3(1, 1, 0);
                Debug.Log("Collided with " + wall);
            }
            else if (wall && direction.x == 1f && direction.y == 1f)
            {
                direction = new Vector3(1, -1, 0);
                Debug.Log("Collided with " + wall);
            }
            else if (wall && direction.x == -1f && direction.y == -1f)
            {
                direction = new Vector3(-1, 1, 0);
                Debug.Log("Collided with " + wall);
            }
        }
    }

