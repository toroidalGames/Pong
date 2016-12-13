using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    private int playerOneScore = 0;
    private int playerTwoScore = 0;
    private static float gameSpeed;
    [SerializeField]private Text playerOneScoreText;
    [SerializeField] private Text playerTwoScoreText;
	// Use this for initialization
	void Start () {
       
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
    }

    public void PlayerTwoScored()
    {
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
    }

}
