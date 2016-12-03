using UnityEngine;

public class PedalController : MonoBehaviour
{
    public float pedalSpeed = 0.1f;
    private float topBounds;
    private float bottomBounds;
    public KeyCode upKey;
    public KeyCode downKey;

    void Start ()
	{
        SetBounds();
    }

    void SetBounds()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        topBounds = bounds.y - 1.5f;
        bottomBounds = -bounds.y + 1.5f;
    }

    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < topBounds)
        {
            transform.Translate(0f, pedalSpeed*Time.deltaTime, 0);
        }
        else if (Input.GetKey(downKey) && transform.position.y > bottomBounds)
        {
            transform.Translate(0f, -pedalSpeed*Time.deltaTime, 0);
        }
    }
}
