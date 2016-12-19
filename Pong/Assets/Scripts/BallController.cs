using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{

    private float velocity;
    private Vector3 direction;
    public bool colourMode = false;
    private GameSettings gameSettings;
    private PongColour currentPongColour;
    int currentColourIndex ;
    private Renderer ballRenderer;

    // Use this for initialization
    void Start()
    {
        gameSettings = GameObject.Find("GameManager").GetComponent<GameSettings>(); 
        velocity = gameSettings.RetrieveGameSpeed();
        direction = new Vector3(1, 1, 0);
        currentColourIndex = (int) currentPongColour;
        ballRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction*velocity*Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D collided)
    {
        var pedal = collided.gameObject.GetComponent<PedalController>();
        var wall = collided.gameObject.GetComponent<WallController>();
        if (pedal)
        {
            direction = new Vector3(-direction.x, direction.y, direction.z);
        }
        
        if (wall)
        {
            direction = new Vector3(direction.x, -direction.y, direction.z);
        }

        if (wall.gameObject.GetComponent<Renderer>().material.color != ballRenderer.material.color)
        {
            currentPongColour = (PongColour)(currentColourIndex = Random.Range(0, 3));
            ballRenderer.material.color = Colour.ColourFromPongColour(currentPongColour);
        }
         
    }
}

