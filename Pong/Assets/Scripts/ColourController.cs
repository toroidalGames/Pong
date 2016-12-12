using UnityEngine;
using System.Collections;

public class ColourController : MonoBehaviour {
    public enum GameObjectColour { Red, Green, Blue, Black };

    public static int ImConfused;
    public GameObjectColour currentObjectColour;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private Color ColourFromPedalColour(GameObjectColour ColourValue)
    {
        switch (ColourValue)
        {
            case GameObjectColour.Red:
                return Color.red;
            case GameObjectColour.Green:
                return Color.green;
            case GameObjectColour.Blue:
                return Color.blue;
            case GameObjectColour.Black:
                return Color.black;
        }
        return Color.red;
    }
}
