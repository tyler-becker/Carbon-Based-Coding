using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public GUISkin skin;
    private int i = 0;

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
            GUI.Label(new Rect(300, 10, 250, 50), "Click on the Chemical Storage to collect chemicals for the experiment.");
        }
        else if (i == 2)
        {
            GUI.Label(new Rect(300, 10, 250, 50), "Click on the Lab Bench to proceed to the Titration.");
        }
    }
}
