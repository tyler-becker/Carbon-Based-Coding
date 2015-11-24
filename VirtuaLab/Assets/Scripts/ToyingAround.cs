using UnityEngine;
using System.Collections;

public class ToyingAround : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    GameObject taco;


    //add  objects to ShelfGrid as parent
    void Start()
    {
        taco = GameObject.Find("ShelfGrid");
        Instantiate<GameObject>(obj).transform.SetParent(taco.transform);
        Instantiate<GameObject>(obj2).transform.SetParent(taco.transform);
        Instantiate<GameObject>(obj3).transform.SetParent(taco.transform);
        Instantiate<GameObject>(obj4).transform.SetParent(taco.transform);


        /*GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
        canvas.GetComponent<Canvas>().worldCamera = GameObject.Find("Main Camera").GetComponent<Camera>();*/
    }

    void interactMethod()
    {
        //UI object hit mesh collider do... or possibly mouse pointer/raycast/etc.
        //Instantiate GameObject
        //Position GameObject
    }
	
}
