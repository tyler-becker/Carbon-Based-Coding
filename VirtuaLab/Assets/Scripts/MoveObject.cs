using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class MoveObject : MonoBehaviour//, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{ 
    //public static GameObject bobby;
    //public Item item;
    //public int amount;
    //public int slot;

    //private Inventory inv;
    //private Tooltip tooltip;
    private Vector2 offset;

    /*void Start()
    {
        bobby = gameObject;
        //inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        //tooltip = inv.GetComponent<Tooltip>();
    }*/

    public void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objectPosition - new Vector2(0, 2.3f); // eventData.position;// - offset;
        //GetComponent<CanvasGroup>().blocksRaycasts = false;
        Debug.Log("I'm dragging!");
        
    }

   /* public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;// - offset;
        Debug.Log("Still dragging..");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        /*this.transform.SetParent(inv.slots[slot].transform);
        this.transform.position = inv.slots[slot].transform.position;
        GetComponent<CanvasGroup>().blocksRaycasts = true; */
        /* Debug.Log("No longer dragging.");
    }*/

    public void OnPointerDown(PointerEventData eventData)
    {
        offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
        Debug.Log("OnPointerDown");
    }

    /*public void OnPointerEnter(PointerEventData eventData)
    {
        //tooltip.Activate(item);
        Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //tooltip.Deactivate(item);
        Debug.Log("OnPointerExit");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    } */
}
