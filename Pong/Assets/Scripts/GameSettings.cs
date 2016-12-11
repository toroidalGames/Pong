using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSettings : MonoBehaviour
{

    [HideInInspector] private static float gameSpeed;
	// Use this for initialization
	void Start () {
	//Object.DontDestroyOnLoad(gameObject);
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

 

}
