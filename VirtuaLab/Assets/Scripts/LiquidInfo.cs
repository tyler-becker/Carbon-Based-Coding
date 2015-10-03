using UnityEngine;
using System.Collections;

public class LiquidInfo : MonoBehaviour
{
    public float radius;
    public float height;
    public float volume;

    void FixedUpdate()
    {
        radius = transform.localScale.x;
        height = transform.localScale.y * 2;
        volume = Mathf.PI * (radius * radius) * height;
    }

}