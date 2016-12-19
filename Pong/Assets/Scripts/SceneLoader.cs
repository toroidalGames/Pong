using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

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

    public void NewRound()
    {
        SceneManager.LoadScene("01_Level_02");
    }

}
