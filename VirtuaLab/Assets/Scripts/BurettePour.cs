using UnityEngine;
using System.Collections;

public class BurettePour : MonoBehaviour
{
    /*
    public Transform[] liquidPosition;
    private int currentPosition;
    public float moveSpeed;
    */

    // Use this for initialization
    void Start()
    {
        /*
        transform.position = liquidPosition[0].position;
        currentPosition = 0;
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (currentPosition < liquidPosition.Length)
        {
            //Transform objects current position to the next position in the liquidPosition array at a specified speed.
            transform.position = Vector3.MoveTowards(transform.position,
                liquidPosition[currentPosition].position, moveSpeed * Time.deltaTime);

            if (transform.position == liquidPosition[currentPosition].position)
            {
                currentPosition++;
            }
        }
        */
    }
}
