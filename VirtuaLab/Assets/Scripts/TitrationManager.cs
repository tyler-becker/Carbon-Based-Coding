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
    public double acidVolume;

    // Use this for initialization
    void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    { 
        neutralColorChange(acidVolume);
        print(acidVolume);

        
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
        //baseRadius = radius of the Base GameObject
        float baseRadius = transform.Find("Base").position.x;
        float acidRadius = transform.Find("Acid").position.x;

        //baseHeight = height of the Base GameObject
        float baseHeight = transform.Find("Base").localScale.y * 2;
        float acidHeight = transform.Find("Acid").localScale.y * 2;

        float volBase = Mathf.PI * (baseRadius * baseRadius) * baseHeight;  //not sure if necessary??
        float volAcid = Mathf.PI * (acidRadius * acidRadius) * acidHeight;  //not sure if necessary??

        //yBase = change in height of the Base (represents change in volume), yBase = x, (((***x = determined by pour speed***)))
        float yBase = 0; //NEEDS AN OUTSIDE VARIABLE TO WORK!!!
        //Calculate yAcid from yBase -- (pi(rB^2)yBase)/(pi(rA^2)) = yAcid
        float yAcid = -((Mathf.PI * (baseRadius * baseRadius) * yBase) / (Mathf.PI * (acidRadius * acidRadius)));

        //Change height of Base GameObject to reflect volume change. (**currently shifts location not change size..)
        transform.Find("Base").Translate(0, yBase, 0);      //may change to access tags
        transform.Find("Acid").Translate(0, yAcid, 0);      //may change to access tags
        

       
    }

    void speedPour()
    {

    }

    void neutralColorChange(double testedVolume)
    {
        //double concentration1 = 0.1;
        double volume1;
        //double concentration2 = 0.12;
       // double volume2 = 25.0;

        volume1 = testedVolume;

        if(volume1 > 25.0 && volume1 < 30.0)
        {
            //Acid very brief color change
        }
        if (volume1 >= 30.0)
        {
            //Acid permanent colorchange
            GameObject acid = GameObject.Find("Acid");
            Shader shader1 = Shader.Find("Red Liquid");
            acid.GetComponent<Renderer>().material.shader = shader1;
        }
    }

    void closeNeutralColor()
    {

    }

    void dripPour()
    {

    }
}
