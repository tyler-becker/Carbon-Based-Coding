using UnityEngine;
using System.Collections;

public class ToolNaOH : MonoBehaviour
{
    public Item item;

    private Inventory inv;
    public Tooltip tooltip;

    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        tooltip = inv.GetComponent<Tooltip>();

        item = GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().item;
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
