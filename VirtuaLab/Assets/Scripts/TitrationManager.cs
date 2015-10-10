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
    public Rect descRect;
    private Rect speedRect = new Rect((float)(Screen.width * 0.37), (float)(Screen.height * 0.35), 100, 50);
    private Rect upRect = new Rect((float)(Screen.width * 0.37), (float)((Screen.height * 0.35) + 30), 50, 50);
    private Rect downRect = new Rect((float)(Screen.width * 0.37), (float)((Screen.height * 0.35) + 90), 50, 50);
    private Rect acidVolRect = new Rect((float)(Screen.width * 0.6), 10, 250, 50);
    private Rect NaOH = new Rect((float)(Screen.width * 0.52), (float)(Screen.height * 0.4), 250, 50);
    private Rect HCl = new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50);
    public double dripSpeed;
    public double acidVolume;
    private string aVol;
    public GUISkin skin;

    

    // Use this for initialization
    void Start ()
    {
        dripSpeed = 0; // 0.01;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        acidVolume += dripSpeed * 5;
        aVol = acidVolume.ToString("0.0");
        neutralColorChange(acidVolume);
        print(acidVolume);
        //dripPour(dripSpeed);
        transferVolume(dripSpeed / 2);


    }

    void OnGUI()
    {
        GUI.skin = skin;

        GUI.Label(acidVolRect, "NaOH dispensed: " + aVol + " mL", skin.GetStyle("label"));
        GUI.Label(descRect, "Step 6: \tDispense the 0.1M NaOH solution into the\n\t"
            + "beaker conatining the unknown concentration\n\tof HCl solution to determine the amount\n\trequired to neutralize it.");
        GUI.Label(speedRect, "Speed: " + dripSpeed * 500);

        GUI.Label(NaOH, "<<<  0.1M NaOH");
        GUI.Label(HCl, "<<<  \"x\"M NaOH");

        if (dripSpeed == 0)
        {
            if (GUI.Button(upRect, "Up"))
            {
                dripSpeed += 0.002;
            }
            GUI.Button(downRect, "Down");
        }
        if (dripSpeed > 0 && dripSpeed < 0.01)
        {
            if (GUI.Button(upRect, "Up"))
            {
                dripSpeed += 0.002;
            }
            if (GUI.Button(downRect, "Down"))
            {
                dripSpeed -= 0.002;
            }
        }
        if (dripSpeed == 0.01)
        {
            GUI.Button(upRect, "Up");
            if (GUI.Button(downRect, "Down"))
            {
                dripSpeed -= 0.002;
            }
        }

    }

    void liquidPour()
    {

    }
    
    void transferVolume(double testedValue)
    {
        GameObject acid = GameObject.Find("Acid");
        GameObject basic = GameObject.Find("Base");

        //baseRadius = radius of the Base GameObject
        float baseRadius = basic.GetComponent<Transform>().transform.localScale.x;
        print(baseRadius);
        float acidRadius = acid.GetComponent<Transform>().transform.localScale.x;
        print(acidRadius);

        //baseHeight = height of the Base GameObject
        float baseHeight = basic.GetComponent<Transform>().transform.localScale.y * 2;
        print(baseHeight);
        float acidHeight = acid.GetComponent<Transform>().transform.localScale.y * 2;
        print(acidHeight);

        float volBase = Mathf.PI * (baseRadius * baseRadius) * baseHeight;  //not sure if necessary??
        print(volBase);
        float volAcid = Mathf.PI * (acidRadius * acidRadius) * acidHeight;  //not sure if necessary??
        print(volAcid);

        //yBase = change in height of the Base (represents change in volume), yBase = x, (((***x = determined by pour speed***)))
        float yBase = -(float)testedValue; 
        print(yBase);
        //Calculate yAcid from yBase -- (pi(rB^2)yBase)/(pi(rA^2)) = yAcid
        float yAcid = -((Mathf.PI * (baseRadius * baseRadius) * yBase) / (Mathf.PI * (acidRadius * acidRadius)));
        print(yAcid);

        //Change height of Base GameObject to reflect volume change.
        if (basic.GetComponent<Transform>().transform.localScale.y > 0)
        {
            basic.GetComponent<Transform>().transform.localScale += new Vector3(0, yBase, 0);
            acid.GetComponent<Transform>().transform.localScale += new Vector3(0, yAcid, 0);
            basic.GetComponent<Transform>().transform.Translate(0, yBase, 0);
            acid.GetComponent<Transform>().transform.Translate(0, yAcid, 0);
        }

       
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

    void dripPour(double value)
    {
        //need a mechanism to respawn drops..

        float speed = -(float)value;                                                        //change to variable that can be adjusted with arrow keys (0-5)
        GameObject baseDrip = GameObject.Find("Base");                          //change to Drop 
        baseDrip.GetComponent<Transform>().transform.Translate(0, speed, 0);    //
    }
}
