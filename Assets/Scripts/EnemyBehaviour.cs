using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int speedMultiplier = 1;
    public int forceMultiplier = 10;
    private bool crashed = false;
    private Vector3 newPosition;

    void OnCollisionEnter (Collision col) {
        if(col.gameObject.name == "Despawn")
        {
            Destroy(this.gameObject);
        } 
        else if (col.gameObject.name == "Player") 
        {
            crashed = true;
            transform.GetComponent<Rigidbody>().AddForce(Vector3.left * forceMultiplier, ForceMode.Impulse);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!crashed)
        {
            transform.Translate((Vector3.back * Time.deltaTime) * speedMultiplier);
        }
    }
}
