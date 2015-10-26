using UnityEngine;

public class DisplayResults : MonoBehaviour {

    public GUISkin skin;
    public Rect resultsRect;
    public Rect quitButton;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
	}

    void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label(resultsRect, "You have found through titration that approximately 30.0 mL of NaOH is required to neutralize the the HCL solution." +
            "\n\n         Plugging this value into the equation: Concentraion1(Volume1) = Concentration2(Volume2) results in:\n\n" +
            "\t\t         0.1M NaOH (30.0mL NaOH) = \"x\" M HCl(25.0mL HCl)\n\n\n\t\t   Solving for \"x\", the concentration of HCl in the beaker is '0.12'M");
        /*if (GUI.Button(quitButton, "Quit"))
        {
            Application.Quit();
        }*/
    }
}
