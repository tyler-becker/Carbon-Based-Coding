using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeScene : MonoBehaviour {

    public GUISkin skin;
    private static int i = 0; //1 due to no intro scene yet.. change to 0 after
    public bool phenolActive;
    string input;

    void Start()
    {
        if (Application.loadedLevel == 8)
        {
            phenolActive = false;

            GameObject.Find("Sodium Hydroxide").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled = !GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled;

            GameObject.Find("Hydrochloric Acid").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled = !GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled;

            GameObject.Find("Phenolphthalein").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled = !GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled;

            GameObject.Find("Beaker").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Beaker").GetComponent<ItemData>().enabled = !GameObject.Find("Beaker").GetComponent<ItemData>().enabled;

            GameObject.Find("Burette").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Burette").GetComponent<ItemData>().enabled = !GameObject.Find("Burette").GetComponent<ItemData>().enabled;
        }

        else if (Application.loadedLevel == 9)
        {
            GameObject.Find("Beaker").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Beaker").GetComponent<ItemData>().enabled = !GameObject.Find("Beaker").GetComponent<ItemData>().enabled;

            GameObject.Find("Burette").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Burette").GetComponent<ItemData>().enabled = !GameObject.Find("Burette").GetComponent<ItemData>().enabled;
        }

        else if (Application.loadedLevel == 12)
        {
            GameObject.Find("Beaker").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Beaker").GetComponent<ItemData>().enabled = !GameObject.Find("Beaker").GetComponent<ItemData>().enabled;

            GameObject.Find("Burette").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            GameObject.Find("Burette").GetComponent<ItemData>().enabled = !GameObject.Find("Burette").GetComponent<ItemData>().enabled;
        }

        else if (Application.loadedLevel == 14)
        {
            GameController.inputText = null;
        }
    }

    void OnMouseDown()
    {
        Application.LoadLevel(Application.loadedLevel + 1);        
    }

    void OnGUI()
    {
        GUI.skin = skin;


        if (Application.loadedLevel == 0)
        {
            GUI.Label(new Rect(20, 10, 1000, 1000), "VirtuaLab : \n\n      Titration Experiment", "Green Bold");

            if (GUI.Button(new Rect(165, 150, 100, 100), "Start", "Green Bold"))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }

        }

        else if (Application.loadedLevel == 1) //Introduction
        {
            GUI.Label(new Rect(283, 80, 800, 1000), "In this experiment, you will be performing an \nAcid/Base Titration to determine an unknown concentration.");

            if (GUI.Button(new Rect(1100, 600, 100, 50), "Next"))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
                Debug.Log(Application.loadedLevel);
            }
        }

        else if (Application.loadedLevel == 2)
        {
            Debug.Log(Application.loadedLevel);

            GUI.Label(new Rect(183, 80, 1000, 1000), "For this experiment the unknown will be a solution of Hydrochloric Acid(HCl) which will be titrated with a solution of 0.1M Sodium Hydroxide(NaOH)");

            if (GUI.Button(new Rect(1100, 600, 100, 50), "Next"))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }

            if (GUI.Button(new Rect(166, 600, 100, 50), "Back"))
            {
                Application.LoadLevel(Application.loadedLevel - 1);
            }
        }

        else if (Application.loadedLevel == 3)
        {
            GUI.Label(new Rect(183, 80, 1000, 1000), "Phenolphthalein will be added to the \"x\"M HCl to provide a color indicator. This will result in the solution turning a reddish color identifying the equivalence point when the two solutions have been neutralized.");

            if (GUI.Button(new Rect(1100, 600, 100, 50), "Next"))
            {

                Application.LoadLevel(Application.loadedLevel + 1);
            }

            if (GUI.Button(new Rect(166, 600, 100, 50), "Back"))
            {
                Application.LoadLevel(Application.loadedLevel - 1);
            }
        }

        else if (Application.loadedLevel == 4)
        {
            GUI.Label(new Rect(183, 80, 1000, 1000), "When you are close to the equivalence point,\n the reddish color will start to linger for a moment before dissipating.\n\nNote: It is best to slow down the pour speed at this point.");

            if (GUI.Button(new Rect(1100, 600, 100, 50), "Next"))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }

            if (GUI.Button(new Rect(166, 600, 100, 50), "Back"))
            {
                Application.LoadLevel(Application.loadedLevel - 1);
            }
        }

        else if (Application.loadedLevel == 5)
        {
            GUI.Label(new Rect(133, 80, 1100, 1000), "Since HCl and NaOH react at a 1:1 ratio, \nthe following formula can be used to determine the unknown concentration:" +
                "\n\n");
            GUI.Label(new Rect(83, 450, 1200, 1000), "In order to solve for \"x\", \nwe must find the volume of NaOH at the equivalence point \nthrough the Titration reaction.");

            if (GUI.Button(new Rect(1100, 600, 100, 50), "Next"))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }

            if (GUI.Button(new Rect(166, 600, 100, 50), "Back"))
            {
                Application.LoadLevel(Application.loadedLevel - 1);
            }
        }

        else if (Application.loadedLevel == 6)
        {
            GUI.Label(new Rect(183, 200, 1000, 1000), "Let's begin by gathering materials for the experiment and setting them up. \n\n\nAfter, we will proceed with the experiment." +
                "\n\n\n\n\n*For a more in depth description, see page 46-51 in your lab manual.*");

            if (GUI.Button(new Rect(1100, 600, 120, 50), "Begin Experiment"))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }

            if (GUI.Button(new Rect(166, 600, 100, 50), "Back"))
            {
                Application.LoadLevel(Application.loadedLevel - 1);
            }

        }



        else if (Application.loadedLevel == 7) //Home to ChemStorage
        {
            GUI.Label(new Rect(300, 10, 300, 100), "Click on the Chemical and Equipment Storage to collect items for the experiment.");
        }

        else if (Application.loadedLevel == 8) //ChemStorage
        {
            GameObject.Find("Burette2(Clone)").GetComponent<MoveBurette>().active = false;
            GameObject.Find("Beaker2(Clone)").GetComponent<MoveBeaker>().active = false;

            if (GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled == false && GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled == false
                && GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 1: Collect Chemicals\n\n      Place the 0.1M NaOH in the Inventory.");
                GameObject.Find("HCl(Clone)").GetComponent<MoveHCl>().active = false;
                GameObject.Find("Phenol(Clone)").GetComponent<MovePhenol>().active = false;
            }

            if (GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled != false && GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled == false
                && GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled == false)
            {

                GUI.Label(new Rect(182, 10, 500, 1000), "Step 1: Collect Chemicals\n\n      Place the \"x\"M HCl in the Inventory.");
                GameObject.Find("HCl(Clone)").GetComponent<MoveHCl>().active = true;
            }

            if (GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled != false && GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled != false
                && GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 1: Collect Chemicals\n\n      Place the Phenolphthalein in the Inventory.");
                GameObject.Find("Phenol(Clone)").GetComponent<MovePhenol>().active = true;
            }

            if (GameObject.Find("Sodium Hydroxide").GetComponent<ItemData>().enabled != false && GameObject.Find("Hydrochloric Acid").GetComponent<ItemData>().enabled != false
                && GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled != false)
            {
                GUI.Label(new Rect(182, 10, 1000, 1000), "Great! \n\nYou have collected all the chemicals needed for the experiment.\nNow we will collect the needed equipment. \n\nProceed to the Next Step.");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    Application.LoadLevel(Application.loadedLevel + 1);
                }
            }
        }

        else if (Application.loadedLevel == 9) //EquipStorage
        {
            if (GameObject.Find("Beaker").GetComponent<ItemData>().enabled == false && GameObject.Find("Burette").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 2: Collect Equipment\n\n      Place the Beaker in the Inventory.");
                GameObject.Find("Burette2(Clone)").GetComponent<MoveBurette>().active = false;
            }

            if (GameObject.Find("Beaker").GetComponent<ItemData>().enabled != false && GameObject.Find("Burette").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 2: Collect Equipment\n\n      Place the Burette in the Inventory.");
                GameObject.Find("Burette2(Clone)").GetComponent<MoveBurette>().active = true;
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

        else if (Application.loadedLevel == 10) // Home to Lab Bench
        {
            GUI.Label(new Rect(300, 10, 250, 50), "Click on the Lab Bench to setup the experiment.");
        }

        else if (Application.loadedLevel == 11) //Setup Equipment
        {
            if (GameObject.Find("Beaker1(Clone)") == null && GameObject.Find("Burette1(Clone)") == null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 3: Setup Equipment\n\n      Place the 50mL burette on the Lab Bench.");
                GUI.Label(new Rect((float)(Screen.width * 0.52), (float)(Screen.height * 0.4), 250, 50), "<<<  Place Here.");
                GameObject.Find("Beaker Outline").GetComponent<Image>().raycastTarget = false;
                GameObject.Find("Beaker Outline").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            }
            else if (GameObject.Find("Beaker1(Clone)") == null && GameObject.Find("Burette1(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 3: Setup Equipment\n\n      Place the 50mL beaker on the Lab Bench.");
                GUI.Label(new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50), "<<<  Place Here.");
                GameObject.Find("Beaker Outline").GetComponent<Image>().raycastTarget = true;
                GameObject.Find("Beaker Outline").GetComponent<Image>().color = new Color32(255, 255, 244, 138);

            }
            else if (GameObject.Find("Beaker1(Clone)") != null && GameObject.Find("Burette1(Clone)") != null)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Fantastic!\n\nYou have assembled the equipment. \nNow we need to pour the chemicals.\n\nProceed to the Next Step.");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    Application.LoadLevel(Application.loadedLevel + 1);
                }
            }
        }

        else if (Application.loadedLevel == 12) //Fill Glassware
        {

            if (GameObject.Find("Acid(Clone)") == null && GameObject.Find("Base(Clone)") == null && GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled == true)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 4: Fill Glassware\n\n      Pour the 0.1M NaOH into the 50mL burette.");
                GUI.Label(new Rect((float)(Screen.width * 0.52), (float)(Screen.height * 0.4), 250, 50), "<<<  Pour here.");
                GameObject.Find("Acid Outline").GetComponent<Image>().raycastTarget = false;
            }

            else if (GameObject.Find("Acid(Clone)") == null && GameObject.Find("Base(Clone)") != null && GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled == true)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 4: Fill Glassware\n\n      Pour the \"x\"M HCl into the 50mL beaker.\n\n      (Note: 25.0mL will be poured into the beaker.)");
                GUI.Label(new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50), "<<<  Pour here");
                GameObject.Find("Acid Outline").GetComponent<Image>().raycastTarget = true;
            }

            else if (GameObject.Find("Acid(Clone)") != null && GameObject.Find("Base(Clone)") != null && GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled == true)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Step 4: Fill Glassware\n\n      Place a few drops of Phenolphthalein in \n      the 50 mL beaker containg the \"x\"M HCl.");
                GUI.Label(new Rect((float)(Screen.width * 0.55), (float)(Screen.height * 0.9), 250, 50), "<<<  Place here.");
                phenolActive = true;
            }

            else if (GameObject.Find("Acid(Clone)") != null && GameObject.Find("Base(Clone)") != null && GameObject.Find("Phenolphthalein").GetComponent<ItemData>().enabled == false)
            {
                GUI.Label(new Rect(182, 10, 500, 1000), "Awesome!\n\nWe are now ready to begin the experiment.\n\nProceed to the Next Step");

                if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
                {
                    Application.LoadLevel(Application.loadedLevel + 1);
                }
            }
        }

        else if (Application.loadedLevel == 13) //Titration
        {
            if (GUI.Button(new Rect(1100, 600, 100, 50), "Next Step"))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }
        }

        else if (Application.loadedLevel == 14) //Results
        {
            input = GameController.inputText;
            double answer;

            GUI.Label(new Rect(133, 80, 1100, 1000), "You have now found the amount of NaOH solution needed to neutralize the HCl solution.", "Bold");

            GUI.Label(new Rect(220, 175, 1000, 1000), "Enter your results:");

            GUI.Label(new Rect(455, 300, 1000, 1000), "x = (0.1M NaOH * Vol NaOH Titrated) / 25.0mL HCl");

            if (input == null)
            {
                //GUI.Label(new Rect(183, 80, 1000, 1000), "You have now found the amount of NaOH solution needed to neutralize the HCl solution.\n\n\n\n         Enter your results:");
            }

            else if (input != null)
            {

                if (Convert.ToDouble(input) >= 28.0 && Convert.ToDouble(input) <= 32.0 && Convert.ToDouble(input) != 30.0)
                {
                    answer = (0.1 * Convert.ToDouble(input)) / 25.0;

                    GUI.Label(new Rect(183, 500, 1000, 1000), "You're answer is correct.        The best possible answer is 0.12M HCl from a result of 30.0mL NaOH", "Green");

                    GUI.Label(new Rect(455, 350, 1000, 1000), "x = (0.1M NaOH * ");
                    GUI.Label(new Rect(620, 353, 1000, 1000), "" + Convert.ToDouble(input) + "mL NaOH", "Highlight");
                    GUI.Label(new Rect(750, 350, 1000, 1000), ") / 25.0mL HCl");

                    GUI.Label(new Rect(455, 400, 1000, 1000), "x = " + answer + "M HCl solution", "Highlight");

                    if (GUI.Button(new Rect(1100, 600, 100, 50), "Main Menu"))
                    {
                        i = 0;
                        Application.LoadLevel(0);
                    }

                }

                else if (Convert.ToDouble(input) == 30.0)
                {
                    answer = (0.1 * Convert.ToDouble(input)) / 25.0;

                    GUI.Label(new Rect(183, 500, 1000, 1000), "You're answer is correct!        Congratulations!", "Green");

                    GUI.Label(new Rect(455, 350, 1000, 1000), "x = (0.1M NaOH * ");
                    GUI.Label(new Rect(620, 353, 1000, 1000), "" + Convert.ToDouble(input) + "mL NaOH", "Highlight");
                    GUI.Label(new Rect(750, 350, 1000, 1000), ") / 25.0mL HCl");

                    GUI.Label(new Rect(455, 400, 1000, 1000), "x = " + answer + "M HCl solution", "Highlight");

                    if (GUI.Button(new Rect(1100, 600, 100, 50), "Main Menu"))
                    {
                        i = 0;
                        Application.LoadLevel(0);
                    }

                }

                else if (Convert.ToDouble(input) < 28.0 || Convert.ToDouble(input) > 32.0)
                {
                    GUI.Label(new Rect(183, 500, 1000, 1000), "You're answer is too far off. Try again.", "Red");

                    if (GUI.Button(new Rect(166, 600, 100, 50), "Back"))
                    {
                        Application.LoadLevel(Application.loadedLevel - 1);

                    }

                }
                else
                {
                    GUI.Label(new Rect(600, 384, 250, 50), "Enter an appropriate value.");
                }
            }

        }
    }

}
