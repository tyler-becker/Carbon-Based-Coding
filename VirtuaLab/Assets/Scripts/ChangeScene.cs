using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public GUISkin skin;

    void OnMouseDown()
    {
        Application.LoadLevel(1);
    }

    void OnGUI()
    {
        GUI.skin = skin;

        GUI.Label(new Rect(100, 10, 250, 50), "Click on the Lab Bench to proceed.");
    }
}
