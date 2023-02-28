using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyShoot : MonoBehaviour
{
    public GameObject plasmaBallGreen;
    private float startDelay = 2;
    private float spawnInterval = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnThing", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnThePurple();
    }

    void SpawnThePurple()
    {
        Vector3 spawnpos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(plasmaBallGreen, transform.position, Quaternion.identity);
    }
}
