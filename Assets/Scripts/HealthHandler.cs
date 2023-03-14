using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthHandler : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;
    [SerializeField]
    private int HealthTaken;
    private int HealthCounter = 30;

    public Text HattieHealth;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HattieHealth.text = HealthCounter.ToString();
        if(HealthCounter == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void SetPoint(int pointvariable)
    {
        HealthCounter += pointvariable;
    }
}
