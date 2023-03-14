using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstanceHandler : MonoBehaviour
{

 //   public static bool gameStarted;
 //   public static bool gameOver;
 //   public static bool gameWon;

    public bool Startscene;
    public bool Quit;
    public bool restart;
    void Start()
    {

    }
   void OnMouseUp()
    {
        if (Startscene)
        {
            SceneManager.LoadScene(1);

        }
        if (Quit)
        {
            Application.Quit();

        }
        if (restart)
        {
            SceneManager.LoadScene(0);

        }
    }



}
