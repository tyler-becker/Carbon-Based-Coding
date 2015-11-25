using UnityEngine;
using System.Collections;

public class colliderChangeScene : MonoBehaviour {

  

    public string level = "Titration";

    // Use this for initialization
    void OnTriggerEnter2D(Collision2D Colider)
    {
         if(Colider.gameObject.tag == "Cube")
         Application.LoadLevel(level);
     }
 }






