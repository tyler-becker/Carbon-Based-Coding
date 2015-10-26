﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    private Item item;
    private string data;
    private GameObject tooltip;

    void Start()
    {
        tooltip = GameObject.Find("Tooltip");
        tooltip.SetActive(false);
    }

    void Update()
    {
        if (tooltip.activeSelf)
        {
            tooltip.transform.position = Input.mousePosition;
        }
    }

    public void Activate(Item item)
    {
        this.item = item;
        ConstructDataString();
        tooltip.SetActive(true);
    }

    public void Deactivate(Item item)
    {
        tooltip.SetActive(false);
    }

    public void ConstructDataString()
    {
        data = "<color=#000000><b>" + item.Title + "</b></color>\n\n" + "Concentration: " + item.Concentration + "\n\n" + item.Description;
        tooltip.transform.GetChild(0).GetComponent<Text>().text = data;
    }
	
}
