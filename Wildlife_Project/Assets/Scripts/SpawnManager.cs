using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int animalIndex;

    private float spawnRangeX = 17.0f;
    private float spawnPosZ;

    [SerializeField,Range(2,5)]
    private float startDelay = 2f;
    [SerializeField, Range(0.1f, 3)]
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosZ = this.transform.position.z;
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Debug.Log(spawnPos);

        animalIndex = Random.Range(0, enemies.Length - 1);
        Instantiate(enemies[animalIndex], spawnPos, enemies[animalIndex].transform.rotation);
    }
}
