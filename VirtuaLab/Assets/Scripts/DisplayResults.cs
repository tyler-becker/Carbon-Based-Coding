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
        GUI.Label(resultsRect, "The titration shows that 30.0 mL of NaOH is required to neutralize the the HCL solution. This means that concentration of HCl in the beaker is '0.13'M");

    }
}
