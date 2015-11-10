using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

    public GUISkin skin;
    private static int i = 5; //1 due to no intro scene yet.. change to 0 after

    void Start()
    {
        if (i == 7)
        {
            GameObject.Find("Beaker").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Beaker").GetComponent<ItemData>().enabled = !GameObject.Find("Beaker").GetComponent<ItemData>().enabled;

            GameObject.Find("Burette").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Burette").GetComponent<ItemData>().enabled = !GameObject.Find("Burette").GetComponent<ItemData>().enabled;
        }
    }

    void OnMouseDown()
    {
        i++;
        Application.LoadLevel(i);        
    }

    void OnGUI()
    {
        GUI.skin = skin;

        if (i == 0)
        {

        }
        else if (i == 1)
        {
            GUI.Label(new Rect(300, 10, 250, 50), "Click on the Chemical Storage to collect chemicals for the experiment.");
        }
        else if (i == 2)
        {

        }
        else if (i == 3)
        {

        }
        else if (i == 4)
        {
            GUI.Label(new Rect(300, 10, 250, 50), "Click on the Equipment Storage to collect equipment for the experiment");
        }
        else if (i == 5)
        {
            GUI.Label(new Rect(300, 10, 250, 50), "Click on the Lab Bench to setup the experiment.");
        }
        else if (i == 6)
        {
            if (GameObject.Find("Beaker1(Clone)") == null && GameObject.Find("Burette1(Clone)") == null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 4: Setup Equipment\n\n      Place the 50mL burette on the Lab Bench.");
                GUI.Label(new Rect((float)(Screen.width * 0.52), (float)(Screen.height * 0.4), 250, 50), "<<<  Burette");
                GameObject.Find("Beaker Outline").GetComponent<Image>().raycastTarget = false;
                GameObject.Find("Beaker Outline").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            }
            else if (GameObject.Find("Beaker1(Clone)") == null && GameObject.Find("Burette1(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 4: Setup Equipment\n\n      Place the 50mL beaker on the Lab Bench.");
                GUI.Label(new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50), "<<<  Beaker");
                GameObject.Find("Beaker Outline").GetComponent<Image>().raycastTarget = true;
                GameObject.Find("Beaker Outline").GetComponent<Image>().color = new Color32(255, 255, 244, 138);
                
            }
            else if (GameObject.Find("Beaker1(Clone)") != null && GameObject.Find("Burette1(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Proceed to the Next Step.");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    i++;
                    Application.LoadLevel(i);
                    Debug.Log(i);
                }
            }
        }
        else if (i == 7)
        {

            if (GameObject.Find("Acid(Clone)") == null && GameObject.Find("Base(Clone)") == null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 5: Fill Glassware\n\n      Pour the 0.1M NaOH into the 50mL burette.");
                GUI.Label(new Rect((float)(Screen.width * 0.52), (float)(Screen.height * 0.4), 250, 50), "<<<  0.1M NaOH");
                GameObject.Find("Acid Outline").GetComponent<Image>().raycastTarget = false;
            }
            else if (GameObject.Find("Acid(Clone)") == null && GameObject.Find("Base(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 5: Fill Glassware\n\n      Pour the \"x\"M HCl into the 50mL beaker.");
                GUI.Label(new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50), "<<<  \"x\"M HCl");
                GameObject.Find("Acid Outline").GetComponent<Image>().raycastTarget = true;
            }
            else if (GameObject.Find("Acid(Clone)") != null && GameObject.Find("Base(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Proceed to the Next Step");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    i++;
                    Application.LoadLevel(i);
                }
            }
        }


    }

}
