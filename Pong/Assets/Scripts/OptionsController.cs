using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public GameObject volumeSliderObject;
    private Slider volumeSlider;
    private GameSettings gameSettings;
    private static bool gameDefaultSettings = true;
	// Use this for initialization
	void Awake ()
	{
        gameSettings = GetComponent<GameSettings>();
        if (volumeSliderObject)
        {
            volumeSlider = volumeSliderObject.GetComponent<Slider>();
            volumeSlider.value = gameSettings.RetrieveGameSpeed();
        }
	    if (gameDefaultSettings)
	    {
	        SetDefault();
	    }

	}
	
	// Update is called once per frame
	void Update () {
	    if (volumeSliderObject)
	    {
            gameSettings.SetGameSpeed(volumeSlider.value);
	        gameDefaultSettings = false;
            Debug.Log("Speed set to: " + gameSettings.RetrieveGameSpeed());
        }
	}

    void SetDefault()
    {
        gameSettings.SetGameSpeed(3f);
    }
}
