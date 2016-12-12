using UnityEngine;
public enum PongColour { Red, Green, Blue, Black };

public class Colour
{
    public static Color ColourFromPongColour(PongColour pongColour)
    {
        switch (pongColour)
        {
            case PongColour.Red:
                return Color.red;
            case PongColour.Green:
                return Color.green;
            case PongColour.Blue:
                return Color.blue;
            case PongColour.Black:
                return Color.black;
        }
        return Color.red;
    }
}
