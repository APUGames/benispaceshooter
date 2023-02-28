using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBounce : MonoBehaviour
{
    public float min = -20f;
    public float max = 20f;
    // Use this for initialization
    void Start()
    {

        min = transform.position.x - 20;
        max = transform.position.x + 20;

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * 10, max - min) + min, transform.position.y, transform.position.z);

    }

}
