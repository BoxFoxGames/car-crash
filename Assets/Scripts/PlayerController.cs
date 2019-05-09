using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speedMultiplier = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Translate((Vector3.left * Time.deltaTime) * speedMultiplier);
        } else if (Input.GetKey("right")) {
            transform.Translate((Vector3.right * Time.deltaTime) * speedMultiplier);
        }
    }
}
