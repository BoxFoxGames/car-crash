using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int speedMultiplier = 1;
    public int scoreGiven = 1_000;
    public bool crashed = false;
    private float forceMultiplier = 5f;
    private Vector3 forceVector;

    void OnCollisionEnter (Collision col) {
        if(col.gameObject.name == "Despawn")
        {
            Destroy(this.gameObject);
        } 
        else if (col.gameObject.name == "Player") 
        {
            crashed = true;
            forceMultiplier = col.gameObject.GetComponent<PlayerController>().forceMultiplier;
            int currentScore = col.gameObject.GetComponent<PlayerController>().score;
            currentScore += scoreGiven;
            col.gameObject.GetComponent<PlayerController>().score = currentScore;
            forceVector = this.transform.position - col.gameObject.transform.position;
            transform.GetComponent<Rigidbody>().AddForce(forceVector * forceMultiplier, ForceMode.Impulse);

        }
    }

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
		if (!crashed)
		{
			transform.Translate((Vector3.back * Time.deltaTime) * speedMultiplier);
		}
	}
}
