using UnityEngine;

public class PedalController : MonoBehaviour
{
    private float speed;
    private float topBounds;
    private float bottomBounds;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode nextColourKey;
    public KeyCode previousColourKey;
    private Renderer pedalRenderer;
    private PongColour currentPongColour;
    public bool colourModeEnabled;
    private GameSettings gameSettings;


    void Start ()
    {
        gameSettings = GameObject.Find("GameManager").GetComponent<GameSettings>();
        speed = gameSettings.RetrieveGameSpeed();
        colourModeEnabled = true;
        pedalRenderer = GetComponent<Renderer>();
        SetBounds();
    }

    void SetBounds()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        float halfPedalLength = transform.localScale.y/2;
        float wallHeight = GameObject.Find("WallTop").transform.localScale.y;
        topBounds = bounds.y - halfPedalLength - wallHeight;
        bottomBounds = -bounds.y+halfPedalLength + wallHeight;
    }


    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < topBounds)
        {
            transform.Translate(0f, speed*Time.deltaTime, 0);
        }
        else if (Input.GetKey(downKey) && transform.position.y > bottomBounds)
        {
            transform.Translate(0f, -speed*Time.deltaTime, 0);
        }

        if (colourModeEnabled)
        {

            int currentColourIndex = (int)currentPongColour;
            if (Input.GetKeyDown(nextColourKey))
            {
                currentPongColour = (PongColour)((currentColourIndex + 1) % 4);
            }
            else if (Input.GetKeyDown(previousColourKey))
            {
                currentPongColour = (PongColour)((currentColourIndex - 1 + 4) % 4);
            }
            pedalRenderer.material.color = Colour.ColourFromPongColour(currentPongColour);
        }
    }
}
