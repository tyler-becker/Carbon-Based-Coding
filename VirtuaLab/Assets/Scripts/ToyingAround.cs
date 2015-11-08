using UnityEngine;
using System.Collections;

public class ToyingAround : MonoBehaviour
{
    public GameObject obj;
    GameObject taco;


    //add  objects to ShelfGrid as parent
    void Start()
    {
        taco = GameObject.Find("ShelfGrid");
        Instantiate<GameObject>(obj).transform.SetParent(taco.transform);
    }

    void interactMethod()
    {
        //UI object hit mesh collider do... or possibly mouse pointer/raycast/etc.
        //Instantiate GameObject
        //Position GameObject
    }
	
}
