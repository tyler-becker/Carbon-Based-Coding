using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeScene : MonoBehaviour {

    public GUISkin skin;
    private static int i = 0; //1 due to no intro scene yet.. change to 0 after
    private InputField input;

    void Start()
    {
        if (Application.loadedLevel == 2)
        {
            GameObject.Find("Sodium Hydroxide").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled = !GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled;

            GameObject.Find("Hydrochloric Acid").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled = !GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled;

            GameObject.Find("Beaker").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Beaker").GetComponent<ItemData>().enabled = !GameObject.Find("Beaker").GetComponent<ItemData>().enabled;

            GameObject.Find("Burette").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Burette").GetComponent<ItemData>().enabled = !GameObject.Find("Burette").GetComponent<ItemData>().enabled;
        }

        else if (Application.loadedLevel == 3)
        {
            GameObject.Find("Beaker").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Beaker").GetComponent<ItemData>().enabled = !GameObject.Find("Beaker").GetComponent<ItemData>().enabled;

            GameObject.Find("Burette").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Burette").GetComponent<ItemData>().enabled = !GameObject.Find("Burette").GetComponent<ItemData>().enabled;
        }
        
        else if (Application.loadedLevel == 6)
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
        Application.LoadLevel(Application.loadedLevel + 1);        
    }

    void OnGUI()
    {
        GUI.skin = skin;

        if (Application.loadedLevel == 0) //Introduction
        {
            GUI.Label(new Rect(600, 384, 250, 50), "<Introduction Goes Here>");


            //if (instructions complete)
            if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
            {
                i++;
                Application.LoadLevel(Application.loadedLevel + 1);
                Debug.Log(i);
            }
        }

        else if (Application.loadedLevel == 1) //Home to ChemStorage
        {
            GUI.Label(new Rect(300, 10, 300, 100), "Click on the Chemical and Equipment Storage to collect items for the experiment.");
        }

        else if (Application.loadedLevel == 2) //ChemStorage
        {



            if (GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled == false && GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 1: Collect Chemicals\n\n      Place the 0.1M NaOH in the Inventory.");
                GameObject.Find("HCl(Clone)").GetComponent<CapsuleCollider>().enabled = false;
            }

            if (GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled != false && GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 1: Collect Chemicals\n\n      Place the \"x\"M HCl in the Inventory.");
                GameObject.Find("HCl(Clone)").GetComponent<CapsuleCollider>().enabled = true;
            }

            if (GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled != false && GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled != false)
            {
                GUI.Label(new Rect(182, 10, 1000, 1000), "Great! \n\nYou have collected all the chemicals needed for the experiment.\nNow we will collect the needed equipment. \n\nProceed to the Next Step.");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    i++;
                    Application.LoadLevel(Application.loadedLevel + 1);
                    Debug.Log(i);
                }
            }
        }

        /*else if (Application.loadedLevel == 3) //Home to EquipStorage
        {
            GUI.Label(new Rect(300, 10, 250, 50), "Click on the Equipment Storage to collect equipment for the experiment.");
        }*/

        else if (Application.loadedLevel == 3) //EquipStorage
        {
            if (GameObject.Find("Beaker").GetComponent<ItemData>().enabled == false && GameObject.Find("Burette").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 2: Collect Equipment\n\n      Place the Beaker in the Inventory.");
                GameObject.Find("Burette2(Clone)").GetComponent<CapsuleCollider>().enabled = false;
            }

            if (GameObject.Find("Beaker").GetComponent<ItemData>().enabled != false && GameObject.Find("Burette").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 2: Collect Equipment\n\n      Place the Burette in the Inventory.");
                GameObject.Find("Burette2(Clone)").GetComponent<CapsuleCollider>().enabled = true;
            }

            if (GameObject.Find("Beaker").GetComponent<ItemData>().enabled != false && GameObject.Find("Burette").GetComponent<ItemData>().enabled != false)
            {
                GUI.Label(new Rect(182, 10, 1000, 1000), "Good Job! \n\nYou have collected all the equipment needed for the experiment.\nNow let's move to the lab bench to get setup.\n\nProceed to the Next Step.");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    i++;
                    Application.LoadLevel(Application.loadedLevel + 1);
                    Debug.Log(i);
                }
            }
        }

        else if (Application.loadedLevel == 4) // Home to Lab Bench
        {
            GUI.Label(new Rect(300, 10, 250, 50), "Click on the Lab Bench to setup the experiment.");
        }

        else if (Application.loadedLevel == 5) //Setup Equipment
        {
            if (GameObject.Find("Beaker1(Clone)") == null && GameObject.Find("Burette1(Clone)") == null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 3: Setup Equipment\n\n      Place the 50mL burette on the Lab Bench.");
                GUI.Label(new Rect((float)(Screen.width * 0.52), (float)(Screen.height * 0.4), 250, 50), "<<<  Burette");
                GameObject.Find("Beaker Outline").GetComponent<Image>().raycastTarget = false;
                GameObject.Find("Beaker Outline").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            }
            else if (GameObject.Find("Beaker1(Clone)") == null && GameObject.Find("Burette1(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 3: Setup Equipment\n\n      Place the 50mL beaker on the Lab Bench.");
                GUI.Label(new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50), "<<<  Beaker");
                GameObject.Find("Beaker Outline").GetComponent<Image>().raycastTarget = true;
                GameObject.Find("Beaker Outline").GetComponent<Image>().color = new Color32(255, 255, 244, 138);
                
            }
            else if (GameObject.Find("Beaker1(Clone)") != null && GameObject.Find("Burette1(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Fantastic!\n\nYou have assembled the equipment. \nNow we need to pour the chemicals.\n\nProceed to the Next Step.");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    i++;
                    Application.LoadLevel(Application.loadedLevel + 1);
                    Debug.Log(i);
                }
            }
        }

        else if (Application.loadedLevel == 6) //Fill Glassware
        {

            if (GameObject.Find("Acid(Clone)") == null && GameObject.Find("Base(Clone)") == null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 4: Fill Glassware\n\n      Pour the 0.1M NaOH into the 50mL burette.");
                GUI.Label(new Rect((float)(Screen.width * 0.52), (float)(Screen.height * 0.4), 250, 50), "<<<  0.1M NaOH");
                GameObject.Find("Acid Outline").GetComponent<Image>().raycastTarget = false;
            }
            else if (GameObject.Find("Acid(Clone)") == null && GameObject.Find("Base(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 4: Fill Glassware\n\n      Pour the \"x\"M HCl into the 50mL beaker.");
                GUI.Label(new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50), "<<<  \"x\"M HCl");
                GameObject.Find("Acid Outline").GetComponent<Image>().raycastTarget = true;
            }
            else if (GameObject.Find("Acid(Clone)") != null && GameObject.Find("Base(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Awesome!\n\nWe are now ready to begin the experiment.\n\nProceed to the Next Step");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    i++;
                    Application.LoadLevel(Application.loadedLevel + 1);
                }
            }
        }

        else if (Application.loadedLevel == 7) //Titration
        {
            if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
            {
                i++;
                Application.LoadLevel(Application.loadedLevel + 1);
                Debug.Log(i);
            }
        }

        else if (Application.loadedLevel == 8) //Results
        {
            string input = GameController.inputText;

            if (input == null)
            {
                GUI.Label(new Rect(600, 384, 250, 50), "<Results Go Here>");
            }

            else if (input != null)
            { 

                if (Convert.ToDouble(input) >= 25.0 && Convert.ToDouble(input) <= 35.0 && Convert.ToDouble(input) != 30.0)
                {
                    GUI.Label(new Rect(600, 384, 250, 50), "You're answer is acceptable. The best answer is 30.0mL");
                }

                else if (Convert.ToDouble(input) == 30.0)
                {
                    GUI.Label(new Rect(600, 384, 250, 50), "You're answer is correct!");
                }

                else if (Convert.ToDouble(input) < 25.0 || Convert.ToDouble(input) > 35.0)
                {
                    GUI.Label(new Rect(600, 384, 250, 50), "You're answer is too far off. Try again.");
                }
                else 
                {
                    GUI.Label(new Rect(600, 384, 250, 50), "Enter an appropriate value.");
                }
            }

            if (GUI.Button(new Rect(1100, 600, 100, 50), "Main Menu"))
            {
                i = 0;
                Application.LoadLevel(0);
                Debug.Log(i);
            }
        }
    }

}
