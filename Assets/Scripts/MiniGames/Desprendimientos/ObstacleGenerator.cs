using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OBSTACLE_DIR : int
{
    LEFT, RIGTH
}

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Tiempo inicial para crear el primer desprendimiento")]
    private float initTime;

    [SerializeField]
    private float minTimeToCreateObstacle, maxTimeToCreateObstacle;

    [SerializeField]
    private List<GameObject> obstaclesPrefabs;

    [SerializeField]
    private Transform leftPos, rightPos;

    [SerializeField]
    private float minForce, maxForce;

    [SerializeField]
    private int extraBarrilChance;


    private void Start()
    {
        Invoke(nameof(CreateObstacle), initTime);
    }

    public void OnObstacleDestroyed()
    {
        float t = Random.Range(minTimeToCreateObstacle, maxTimeToCreateObstacle);
        Invoke(nameof(CreateObstacle), t);
        int extra = Random.Range(0, extraBarrilChance);
        if(extra == 0)
            CreateObstacle();
    }

    private void OnDestroy()
    {
        CancelInvoke();
    }

    private void CreateObstacle()
    {
        GameObject currentObstacle = Instantiate(obstaclesPrefabs[Random.Range(0, obstaclesPrefabs.Count)]);
        OBSTACLE_DIR oBSTACLE_DIR = (OBSTACLE_DIR)Random.Range(0,2);
        currentObstacle.transform.position = oBSTACLE_DIR.Equals(OBSTACLE_DIR.RIGTH) ? rightPos.position : leftPos.position;
        currentObstacle.GetComponent<Obstacle>().InitObstacle(this, oBSTACLE_DIR, Random.Range(minForce, maxForce));
    }
}
