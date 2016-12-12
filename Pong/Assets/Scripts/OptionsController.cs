using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public GameObject volumeSliderObject;
    private Slider volumeSlider;
    private GameSettings gameSettings;
	// Use this for initialization
	void Start ()
	{
        gameSettings = GetComponent<GameSettings>();
	    //if (volumeSliderObject)
	    //{
            volumeSlider = volumeSliderObject.GetComponent<Slider>();
            volumeSlider.value = gameSettings.RetrieveGameSpeed();
        //}
        SetDefault();
	}
	
	// Update is called once per frame
	void Update () {
	gameSettings.SetGameSpeed(volumeSlider.value);
        Debug.Log("Speed set to: "+ gameSettings.RetrieveGameSpeed());
	}

    void SetDefault()
    {
        gameSettings.SetGameSpeed(3f);
    }
}
