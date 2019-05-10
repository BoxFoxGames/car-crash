using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackController : MonoBehaviour
{
    private int speedMultiplier = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        speedMultiplier = GameObject.Find("Player").GetComponent<PlayerController>().speedMultiplier;
    }

    // Update is called once per frame
    void Update()
    {

    }

	void FixedUpdate()
	{
		transform.Translate((Vector3.back * Time.deltaTime) * speedMultiplier);
	}
}
