using UnityEngine;

public class PedalController : MonoBehaviour
{

    enum CurrentColourEnum
    {
        Red = 0,
        Green =1,
        Blue =2,
        Black =3
    }

    public float pedalSpeed = 0.1f;
    private float topBounds;
    private float bottomBounds;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode nextPedalColour;
    public KeyCode previousPedalColour;
    private Renderer pedalRenderer;
    private int colourValue;
    public bool colourMode = false;


    void Start ()
    {
        colourValue = 3;
        pedalRenderer = GetComponent<Renderer>();
        colourMode = true;
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
    void ChangePedalColour(int colorval)
    {
        colourValue = colorval;
        switch ((CurrentColourEnum)colourValue)
        {
                case CurrentColourEnum.Red:
                pedalRenderer.material.color = Color.red;
                break;
            case CurrentColourEnum.Green:
                pedalRenderer.material.color = Color.green;
                break;
            case CurrentColourEnum.Blue:
                pedalRenderer.material.color = Color.blue;
                break;
            case CurrentColourEnum.Black:
                pedalRenderer.material.color = Color.black;
                break;
                
        }
    }




    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < topBounds)
        {
            transform.Translate(0f, pedalSpeed*Time.deltaTime, 0);
        }
        else if (Input.GetKey(downKey) && transform.position.y > bottomBounds)
        {
            transform.Translate(0f, -pedalSpeed*Time.deltaTime, 0);
        }

        if (colourMode == true)
        {
            if (Input.GetKeyDown(nextPedalColour))
            {
                colourValue++;
            }
            else if (Input.GetKeyDown(previousPedalColour))
            {
                colourValue--;
            }
            if (colourValue >= 4)
            {
                colourValue = 0;
            }
            else if (colourValue < 0)
            {
                colourValue = 3;
            }
            
            
            ChangePedalColour(colourValue);
        }

    }
}
