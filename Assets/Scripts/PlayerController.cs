using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int health = 3;
    public float speed = 10.0f;
    public GameObject laserPrefab;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        //transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.up);

        if(transform.position.y > 1)
        {
            transform.position = new Vector3(transform.position.x, 1, 0f);
        }

        //block both -10 and 10 x axis

        if(transform.position.x > 15f)
        {
            transform.position = new Vector3(15f, transform.position.y, 0f);
        }

        if (transform.position.x < -15f)
        {
            transform.position = new Vector3(-15f, transform.position.y, 0f);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
    }
}
