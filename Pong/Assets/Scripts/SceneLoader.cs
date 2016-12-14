using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadGame()
    {
        SceneManager.LoadScene("01_Level_02");
        GameSettings.playerOneScore = 0;
        GameSettings.playerTwoScore = 0;
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("00_Settings");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("00_MainMenu");
    }

}
