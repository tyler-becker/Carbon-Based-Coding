using UnityEngine;
using System.Collections;

public class ToolBurette : MonoBehaviour {

    private Item item;

    private Inventory inv;
    private Tooltip tooltip;

    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        tooltip = inv.GetComponent<Tooltip>();

        item = GameObject.Find("Burette").GetComponent<ItemData>().item;
    }

    public void OnMouseEnter()
    {
        tooltip.Activate(item);
    }

    public void OnMouseExit()
    {
        tooltip.Deactivate(item);
    }

    void OnDestroy()
    {
        tooltip.Deactivate(item);
    }
}
