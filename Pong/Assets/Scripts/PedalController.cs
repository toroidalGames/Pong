using UnityEngine;

public class PedalController : MonoBehaviour
{
    private enum PedalColour{Red, Green, Blue, Black};

    private float speed;
    private float topBounds;
    private float bottomBounds;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode nextColourKey;
    public KeyCode previousColourKey;
    private Renderer pedalRenderer;
    private PedalColour currentPedalColour;
    public bool colourModeEnabled;
    private ColourController pedalColourController;
    private GameSettings gameSettings;


    void Start ()
    {
        gameSettings = GetComponent<GameSettings>();
        speed = gameSettings.RetrieveGameSpeed();
        pedalColourController = GetComponent<ColourController>();
        pedalColourController.currentObjectColour = ColourController.GameObjectColour.Black;
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
 
    private Color ColourFromPedalColour(PedalColour pedalColourValue)
    {
        switch (pedalColourValue)
        {
            case PedalColour.Red:
                return Color.red;
            case PedalColour.Green:
                return Color.green;
            case PedalColour.Blue:
                return Color.blue;
            case PedalColour.Black:
                return Color.black;
        }
        return Color.red;
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
            var colourTest = pedalColourController.currentObjectColour;

            int currentPedalColourIndex = (int)pedalColourController.currentObjectColour;
            if (Input.GetKeyDown(nextColourKey))
            {
                currentPedalColour = (PedalColour)((currentPedalColourIndex) % 4);
            }
            else if (Input.GetKeyDown(previousColourKey))
            {
                currentPedalColour = (PedalColour)((currentPedalColourIndex - 1 + 4) % 4);
            }
            pedalRenderer.material.color = ColourFromPedalColour(currentPedalColour);
        }
    }
}
