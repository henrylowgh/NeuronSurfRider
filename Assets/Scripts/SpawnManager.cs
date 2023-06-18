using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab; // 1 = Obstacle
    private Vector3 spawnPos1 = new Vector3(25, 5, 0); 
    private float startDelay1 = 2; 
    private float spawnInterval1 = 2;

    public GameObject neuronPrefab; // 2 = Neuron
    private Vector3 spawnPos2;
    private float startDelay2 = 11.5f;
    private float spawnInterval2 = 15.5f;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay1, spawnInterval1);
        InvokeRepeating("SpawnNeuron", startDelay2, spawnInterval2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos1, obstaclePrefab.transform.rotation);
        }
    }

    void SpawnNeuron()
    {
        spawnPos2 = new Vector3(200, Random.Range(-1, 2), 0);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(neuronPrefab, spawnPos2, neuronPrefab.transform.rotation);
        }
    }
}
