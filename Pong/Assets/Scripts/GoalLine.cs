using UnityEngine;
using System.Collections;

public class GoalLine : MonoBehaviour {
    GameSettings gameSettings;

    // Use this for initialization
    void Start ()
    {
        gameSettings = GameObject.Find("GameManager").GetComponent<GameSettings>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter2D(Collider2D ball)
    {
        if (gameObject.tag == "Player1GoalLine")
        {
            gameSettings.PlayerTwoScored();
        }
        else if (gameObject.tag == "Player2GoalLine")
        {
            gameSettings.PlayerOneScored();
        }
    }
}
