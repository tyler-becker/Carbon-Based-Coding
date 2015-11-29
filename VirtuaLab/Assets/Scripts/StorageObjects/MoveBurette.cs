using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class MoveBurette : MonoBehaviour
{
    private Vector2 offset;
    public bool active;

    void Start()
    {
        active = false;
    }

    public void OnMouseDrag()
    {
        if (active)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition - new Vector2(0, 2.3f);
            Debug.Log("I'm dragging!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Inventory")
        {

            GameObject.Find("Burette").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Burette").GetComponent<ItemData>().enabled = true;
            Destroy(this.gameObject);
            Debug.Log("It works finally");
        }
    }

}
