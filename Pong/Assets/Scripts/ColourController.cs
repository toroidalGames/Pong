using UnityEngine;
using System.Collections;

public class ColourController : MonoBehaviour {
    enum CurrentColourEnum
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Black = 3
    }

    public GameObject player1;
    public GameObject player2;
    private int colourValue;
    public bool colourMode = true;
    private Renderer pedalRenderer;

    // Use this for initialization
    void Start ()
    {
        pedalRenderer = player1.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (colourMode == true)
        {
            if (Input.GetKeyDown(player1.nextPedalColour))
            {
                colourValue++;
            }
            else if (Input.GetKeyDown(player1.previousPedalColour))
            {
                colourValue--;
            }

            if (Input.GetKeyDown(player1.nextPedalColour))
            {
                colourValue++;
            }
         
            if (colourValue >= 4)
            {
                colourValue = 0;
            }
            else if (colourValue < 0)
            {
                colourValue = 3;
            }


            ChangePedalColour(colourValue,player1);
        }
    }

    void ChangePedalColour(int colorval, PedalController pedal)
    {
        pedal.GetComponent<Renderer>() = objectToColourChange;
        colourValue = colorval;
        switch ((CurrentColourEnum)colourValue)
        {
            case CurrentColourEnum.Red:
                objectToColourChange.material.color = Color.red;
                break;
            case CurrentColourEnum.Green:
                objectToColourChange.material.color = Color.green;
                break;
            case CurrentColourEnum.Blue:
                objectToColourChange.material.color = Color.blue;
                break;
            case CurrentColourEnum.Black:
                objectToColourChange.material.color = Color.black;
                break;
        }
    }


}
