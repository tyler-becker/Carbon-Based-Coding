using UnityEngine;
using System.Collections;

public class TitrationManager : MonoBehaviour
{
    public Rect descRect;
    private Rect speedRect = new Rect((float)(Screen.width * 0.37), (float)(Screen.height * 0.35), 100, 50);
    private Rect upRect = new Rect((float)(Screen.width * 0.37), (float)((Screen.height * 0.35) + 30), 50, 50);
    private Rect downRect = new Rect((float)(Screen.width * 0.37), (float)((Screen.height * 0.35) + 90), 50, 50);
    private Rect acidVolRect = new Rect((float)(Screen.width * 0.6), 10, 250, 50);
    private Rect NaOH = new Rect((float)(Screen.width * 0.52), (float)(Screen.height * 0.4), 250, 50);
    private Rect HCl = new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50);
    //private Rect levelRect = new Rect((float)(Screen.width * 0.37 + 90), (float)((Screen.height * 0.35) + 90), 80, 50);
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

    IEnumerator delayCoroutine(float seconds)
    {
        GameObject.Find("Acid").GetComponent<Animator>().Stop();
        yield return new WaitForSeconds(seconds);
        GameObject.Find("Acid").GetComponent<Animator>().Play("New Animation", 0, 0);
    }

    void OnGUI()
    {
        GUI.skin = skin;

        GUI.Label(acidVolRect, "NaOH dispensed: " + aVol + " mL", skin.GetStyle("label"));
        GUI.Label(descRect, "Step 5: Titration\n\n      Dispense the 0.1M NaOH solution into the\n"
            + "      beaker containing the unknown concentration\n      of HCl solution to determine the amount\n      required to neutralize it.\n\n"
            + "      When you feel you have the right amount\n      you can proceed to the next step.");
        GUI.Label(speedRect, "Speed: " + dripSpeed * 500);

        if (aVol == "50.0")
        {
            dripSpeed = 0;
            GUI.Button(downRect, "Down");
            GUI.Button(upRect, "Up");
        }

        if (acidVolume >= 30.0 && acidVolume < 50.0)
        {
            /*if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
            {
                Application.LoadLevel(2);
            }*/
        }

        GUI.Label(NaOH, "<<<  0.1M NaOH");
        GUI.Label(HCl, "<<<  \"x\"M HCl");

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
        double volume1;
        double speed = dripSpeed * 500;

    volume1 = testedVolume;

        if(volume1 < 30.0 && volume1 > 25.0)
        {
            //set Animation Active
            //stop Animation if dripSpeed == 0
            //change animation speed based on drip Speed
            if (speed == 1)
            {
                GameObject.Find("Acid").GetComponent<Animator>().enabled = true;
                GameObject.Find("Acid").GetComponent<Animator>().Play("New Animation", 0);
            }

            else if (speed == 2)
            {
                GameObject.Find("Acid").GetComponent<Animator>().enabled = true;
                GameObject.Find("Acid").GetComponent<Animator>().Play("ColorChange2", 0);
            }

            else if (speed == 3)
            {
                GameObject.Find("Acid").GetComponent<Animator>().enabled = true;
                GameObject.Find("Acid").GetComponent<Animator>().Play("ColorChange3", 0);
            }

            else if (speed == 4)
            {
                GameObject.Find("Acid").GetComponent<Animator>().enabled = true;
                GameObject.Find("Acid").GetComponent<Animator>().Play("ColorChange4", 0);
            }

            else if (speed == 5)
            {
                GameObject.Find("Acid").GetComponent<Animator>().enabled = true;
                GameObject.Find("Acid").GetComponent<Animator>().Play("ColorChange5", 0);
            }

            else if (speed == 0)
            {
                GameObject.Find("Acid").GetComponent<Animator>().enabled = false;
                GameObject.Find("Acid").GetComponent<MeshRenderer>().materials[0].SetColor("_EmissionColor", new Color(1, 1, 1, 0));
            }
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
