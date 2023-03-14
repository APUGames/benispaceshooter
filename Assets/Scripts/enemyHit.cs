using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enemyHit : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Army")
        {
          Destroy(gameObject);
          Destroy(other.gameObject);
          GameObject.Find("HitPoints").GetComponent<HealthHandler>().SetPoint(1);
        }

        else if(other.gameObject.tag == "Beni")
        {
             SceneManager.LoadScene(3);
        }

    }



}
