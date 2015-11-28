using UnityEngine;
using System.Collections;

public class LiquidInfo : MonoBehaviour
{
    public float radius;
    public float height;
    public float volume;
    public Color color;


    void Start()
    {
        this.GetComponent<MeshRenderer>().materials[0].SetColor("_EmissionColor", color);
    }

    void FixedUpdate()
    {
        radius = transform.localScale.x;
        height = transform.localScale.y * 2;
        volume = Mathf.PI * (radius * radius) * height;
        this.GetComponent<MeshRenderer>().materials[0].SetColor("_EmissionColor", color);
    }

}