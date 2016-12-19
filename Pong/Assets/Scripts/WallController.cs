using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {
    private PongColour currentPongColour;
    private Renderer wallRenderer;
    private bool colourMode = true;
    // Use this for initialization
    void Start ()
    {
        wallRenderer = GetComponent<Renderer>();
        StartCoroutine(ChangeWallColour());
    }

    // Update is called once per frame
    void Update ()
	{
        

    }

    private IEnumerator ChangeWallColour()
    {
        int currentColourIndex = (int)currentPongColour;
        while (colourMode)
        {
            currentPongColour = (PongColour)(currentColourIndex = Random.Range(0, 3));
            wallRenderer.material.color = Colour.ColourFromPongColour((currentPongColour));
            yield return new WaitForSecondsRealtime(2f);
        }


}


}
