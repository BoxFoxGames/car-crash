using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    private GameObject enemyPrefab;
    private GameObject[] enemies;
    public GameObject spawnParent;
    private GameObject itemPrefab;
    private GameObject[] items;
    public GameObject itemSpawnParent;
    public float spawnRate = 0.5f;
    private float nextSpawn = 0.0f;
    public float itemSpawnRate = 0.5f;
    private float nextItemSpawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        enemies = Resources.LoadAll<GameObject>("Prefabs/Enemies");
        items = Resources.LoadAll<GameObject>("Prefabs/Items");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;

            int spawnPoint = Random.Range(0, transform.childCount);

            enemyPrefab = enemies[Random.Range(0, enemies.Length)];

            GameObject enemy = Instantiate(enemyPrefab, transform.GetChild(spawnPoint).position, enemyPrefab.transform.rotation, spawnParent.transform) as GameObject;
        }
        if (Time.time > nextItemSpawn) {
            nextItemSpawn = Time.time + itemSpawnRate;

            int spawnPoint = Random.Range(0, transform.childCount);

            itemPrefab = items[Random.Range(0, items.Length)];

            GameObject enemy = Instantiate(itemPrefab, transform.GetChild(spawnPoint).position, itemPrefab.transform.rotation, itemSpawnParent.transform) as GameObject;
        }
    }
}
