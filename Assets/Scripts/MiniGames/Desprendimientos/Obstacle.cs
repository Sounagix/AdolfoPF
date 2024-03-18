using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Obstacle : MonoBehaviour
{
    private ObstacleGenerator obstacleGenerator;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void InitObstacle(ObstacleGenerator _obstacleGenerator,OBSTACLE_DIR oBSTACLE_DIR, float _vel)
    {
        obstacleGenerator = _obstacleGenerator;
        Vector3 dir = oBSTACLE_DIR.Equals(OBSTACLE_DIR.RIGTH) ? Vector3.left : Vector3.right;
        rb.AddForce(dir * _vel, ForceMode.Impulse);
    }

    private void OnBecameInvisible()
    {
        obstacleGenerator.OnObstacleDestroyed();
        Destroy(gameObject);
    }
}
