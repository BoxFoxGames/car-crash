using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] enemies;
    public GameObject spawnParent;
    public float spawnRate = 0.5f;
    private float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemies = Resources.LoadAll<GameObject>("Prefabs/Enemies");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;

            int spawnPoint = Random.Range(0, transform.childCount);

            enemy = enemies[Random.Range(0, enemies.Length)];

            GameObject clone = Instantiate(enemy, transform.GetChild(spawnPoint).transform.position, Quaternion.identity, spawnParent.transform) as GameObject;
        }
    }
}
