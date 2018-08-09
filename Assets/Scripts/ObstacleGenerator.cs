using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

    public Transform player;
    public GameObject playerObject;
    private float initialForwardForce;
    public GameObject[] obstacles;
    public int offset = 30;
    public float spawnTime = 1f;
    public float timeToWait = 0.5f;
    public int obstaclesSpawned;
    public int initialObstacles = 5;
    private Transform playerInitialPosition;

    private void Start()
    {
        playerInitialPosition = player.transform;
        initialForwardForce = playerObject.GetComponent<PlayerMovement>().forwardForce;
        obstacles = Resources.LoadAll<GameObject>("Obstacles");
        for (obstaclesSpawned = 0; obstaclesSpawned < initialObstacles; obstaclesSpawned++)
        {
            SpawnObstacles(obstaclesSpawned);
        }
    }

    void FixedUpdate () {
        if (Time.time >= spawnTime & obstaclesSpawned >= initialObstacles)
        {
            SpawnObstacles(obstaclesSpawned);
            obstaclesSpawned++;
            spawnTime = Time.time + timeToWait;
        
        }
        RemovePastObject();

    }

    void SpawnObstacles(int obstaclesSpawned)
    {
        int randomIndex = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[randomIndex],
             new Vector3(0, 1, playerInitialPosition.position.z + offset * (obstaclesSpawned + 1)),
             Quaternion.identity);
    }

    void RemovePastObject()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obstacle in obstacles)
        {
            if (obstacle.transform.position.z < player.position.z - 10)
            {
                Destroy(obstacle);
            }
        }
    }
}
