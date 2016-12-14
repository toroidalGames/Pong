using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public static int playerOneScore = 0;
    public static int playerTwoScore = 0;
    private static float gameSpeed;
    [SerializeField]private Text playerOneScoreText;
    [SerializeField] private Text playerTwoScoreText;
    public static bool colourModeEnabled;
    // Use this for initialization
    void Start () {
        playerOneScoreText.text = playerOneScore.ToString();
        playerTwoScoreText.text = playerTwoScore.ToString();
    }

    // Update is called once per frame
    void Update () {

	   
	}

    public void SetGameSpeed(float speed)
    {
        gameSpeed = speed;
    }

    public float RetrieveGameSpeed()
    {
        return gameSpeed;
    }

    public void PlayerOneScored()
    {
        playerOneScore++;
        playerOneScoreText.text = playerOneScore.ToString();
        Debug.Log("PLayeronescore: "+ playerOneScore+"Player score text: "+playerOneScoreText);
        if (playerOneScore ==1)
        {
            SceneManager.LoadScene("02_Player1Win");
        }
    }

    public void PlayerTwoScored()
    {
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
        if (playerTwoScore == 1)
        {
            SceneManager.LoadScene("02_Player2Win");
        }
    }

    public void ColourModeActivation()
    {
        int colourToggle = 0;
        if (colourToggle == 0)
        {
            colourModeEnabled = true;
            Debug.Log("Colour mode activated bool value:  " + colourModeEnabled);
            colourToggle = 1;
        }
        else if (colourToggle == 1)
        {
            colourModeEnabled = false;
            Debug.Log("Colour mode deactivated bool value:  " + colourModeEnabled);
            colourToggle = 0;
        }
     
    }
}
