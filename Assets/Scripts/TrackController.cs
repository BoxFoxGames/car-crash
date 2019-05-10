using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackController : MonoBehaviour
{
    public GameObject roadPrefab;
    public GameObject roadSpawnParent;
    private GameObject lastRoad;
    private int speedMultiplier = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        speedMultiplier = GameObject.Find("Player").GetComponent<PlayerController>().speedMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        lastRoad = roadSpawnParent.transform.GetChild(0).gameObject;
        Vector3 spawnPoint = new Vector3(0f, 0f, roadSpawnParent.transform.GetChild(1).position.z + 30);
        if (lastRoad.transform.position.z <= -30) {
            GameObject road = Instantiate(roadPrefab, spawnPoint, Quaternion.identity, roadSpawnParent.transform) as GameObject;
            Destroy(lastRoad);
        }
    }

	void FixedUpdate()
	{
		transform.Translate((Vector3.back * Time.deltaTime) * speedMultiplier);
	}
}
