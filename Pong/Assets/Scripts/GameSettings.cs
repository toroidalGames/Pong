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
    public static bool colourModeEnabled = false;
    private SceneLoader sceneLoader;
    [SerializeField]private Toggle toggle;
    // Use this for initialization
    void Start ()
    {
        sceneLoader = GetComponent<SceneLoader>();
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
        sceneLoader.NewRound();
        Debug.Log("PLayeronescore: "+ playerOneScore+"Player score text: "+playerOneScoreText);

        if (playerOneScore == 2)
        {
            SceneManager.LoadScene("02_Player1Win");
        }
    }

    public void PlayerTwoScored()
    {
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
        sceneLoader.NewRound();

        if (playerTwoScore == 2)
        {
            SceneManager.LoadScene("02_Player2Win");
        }
    }

    public void ColourModeActivation()
    {
        int colourToggle = 0;
        if (toggle.isOn)
        {
            colourModeEnabled = true;
            Debug.Log("Colour mode activated bool value:  " + colourModeEnabled);
            colourToggle = 1;
        }
        else if (!toggle.isOn)
        {
            colourModeEnabled = false;
            Debug.Log("Colour mode deactivated bool value:  " + colourModeEnabled);
            colourToggle = 0;
        }
     
    }
}
