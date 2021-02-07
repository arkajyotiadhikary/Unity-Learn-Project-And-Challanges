using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;

    public float posX;
    public float posZ;

    public float startDelay = 2;
    public float timeDeleay = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,timeDeleay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0,animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-posX,posX),0,posZ);

        Instantiate(animalPrefab[animalIndex],spawnPos,animalPrefab[animalIndex].transform.rotation);
    }
}
