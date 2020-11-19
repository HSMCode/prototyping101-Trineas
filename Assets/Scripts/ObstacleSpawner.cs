using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject wheel;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {

        InvokeRepeating("spawnObstacle", startDelay, spawnInterval);


    }

    void Update()
    {
        transform.Translate(Vector3.forward * 5f * Time.deltaTime);

        transform.Rotate(Vector3.left * 50f * Time.deltaTime);
    }


    void spawnObstacle()
    {
        Instantiate(wheel, this.transform.position, wheel.transform.rotation);
    }
}
