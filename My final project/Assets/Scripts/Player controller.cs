using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController: MonoBehaviour
{
    // Start is called before the first frame update
     public Transform cameraPosition;
    // Update is called once per frame
   private void Update()
    {
        transform.position = cameraPosition.position;
    }
}