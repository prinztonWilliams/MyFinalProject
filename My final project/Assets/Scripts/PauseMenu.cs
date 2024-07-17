using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    // Start is called before the first frame update
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape)) 
       {
        if (GameIsPaused)
        {
            ResumeGame();
        }else
        {
            PasueM
        }
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
