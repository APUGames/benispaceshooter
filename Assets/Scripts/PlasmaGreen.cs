using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaGreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(15.0f * Time.deltaTime * Vector3.forward);
    }
}
