using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int rotationAnglePerSecond = 180;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Despawn")
        {
            Destroy(this.gameObject);
        } 
        else if (other.gameObject.name == "Player") 
        {
            int currentCoinCount = other.gameObject.GetComponent<PlayerController>().coins;
            currentCoinCount ++;
            other.gameObject.GetComponent<PlayerController>().coins = currentCoinCount;
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, (rotationAnglePerSecond * Time.deltaTime), Space.Self);
    }
}
