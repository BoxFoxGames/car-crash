using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public int straveMultiplier = 1;
    public int speedMultiplier = 1;
    public float forceMultiplier = 5f;
    public int score = 0;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	void FixedUpdate()
	{
		if (Input.GetKey("left"))
		{
			transform.Translate((Vector3.left * Time.deltaTime) * straveMultiplier);
		} else if (Input.GetKey("right")) {
			transform.Translate((Vector3.right * Time.deltaTime) * straveMultiplier);
		}
        SetScoreText();
	}

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString() + "$";
    }
}
