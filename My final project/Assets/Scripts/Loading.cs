using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter(Collider other) 

{
    if (other.tag == "LevelExit")
    {
        SceneManager.LoadScene("Level2");
    }
}
}