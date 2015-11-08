using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    public int amount;
    public int slot;

    private Inventory inv;
    private Tooltip tooltip;
    private Vector2 offset;

    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        tooltip = inv.GetComponent<Tooltip>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (item != null)
        {
            this.transform.SetParent(this.transform.parent.parent);
            this.transform.position = eventData.position - offset;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (item != null)
        {
            this.transform.position = eventData.position - offset;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (this.transform == GameObject.Find("Beaker").transform && eventData.pointerCurrentRaycast.gameObject == GameObject.Find("Beaker Outline"))
        {
            GameObject.Find("Beaker Outline").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Beaker").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Beaker").GetComponent<ItemData>().enabled = !GameObject.Find("Beaker").GetComponent<ItemData>().enabled;
            Instantiate<GameObject>(Resources.Load<GameObject>("Objects/Beaker1"));
        }
        else if (this.transform == GameObject.Find("Burette").transform && eventData.pointerCurrentRaycast.gameObject == GameObject.Find("Burette Outline"))
        {
            GameObject.Find("Burette Outline").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Burette").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Burette").GetComponent<ItemData>().enabled = !GameObject.Find("Burette").GetComponent<ItemData>().enabled;
            Instantiate<GameObject>(Resources.Load<GameObject>("Objects/Burette1"));
        }
        else if (this.transform == GameObject.Find("Hydrochloric Acid").transform && eventData.pointerCurrentRaycast.gameObject == GameObject.Find("Acid Outline"))
        {
            GameObject.Find("Hydrochloric Acid").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled = !GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled;
            Instantiate<GameObject>(Resources.Load<GameObject>("Objects/Acid"));
        }
        else if (this.transform == GameObject.Find("Sodium Hydroxide").transform && eventData.pointerCurrentRaycast.gameObject == GameObject.Find("Base Outline"))
        {
            GameObject.Find("Sodium Hydroxide").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled = !GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled;
            Instantiate<GameObject>(Resources.Load<GameObject>("Objects/Base"));
        }
       
            this.transform.SetParent(inv.slots[slot].transform);
            this.transform.position = inv.slots[slot].transform.position;
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (item != null)
        {
            offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltip.Activate(item);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.Deactivate(item);
    }
}
