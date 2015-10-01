using UnityEngine;
using System.Collections;

/*
liquidPour()            = a method that animates liquid pour (currently done by BurretePour class)
transferVolume()        = a method that transfers volume dispensed from burette to beaker accurately/visually
speedPour()             = a method that allows the user to adjust the pour speed
neutralColorChange()    = a method that changes the color of the liquid in the beaker when it is neutralized
closeNeutralColor()     = a method that changes the color of the inthe beaker for a frame or two when close to neutral 
dripPour()              = a method that animates a drop or steady pour from the burette to the beaker
*/


public class TitrationManager : MonoBehaviour
{
    public Rect speedRect, upRect, downRect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        /*if (transform.position = BurettePour.liquidPosition[1])
        {

        }*/
    }

    void OnGUI()
    {
        GUI.Label(speedRect, "Speed");
        GUI.Button(upRect, "Up");
        GUI.Button(downRect, "Down");
    }

    void liquidPour()
    {

    }
    
    void transferVolume()
    {
        //may need to use a seperate script for each object??
        float obj1radius = transform.position.x;
        float obj2radius = 0;

        float height1 = 0;
        //Calculate height2 from height1 -- (pi(r^2)height1)/(pi(R^2)) = height2
        float height2 = (Mathf.PI * (obj1radius * obj1radius) * height1) / (Mathf.PI * (obj2radius * obj2radius));

        float volume1 = Mathf.PI * (obj1radius * obj1radius) * height1;
        float volume2 = Mathf.PI * (obj2radius * obj2radius) * height2;
    }

    void speedPour()
    {

    }

    void neutralColorChange()
    {

    }

    void closeNeutralColor()
    {

    }

    void dripPour()
    {

    }
}
