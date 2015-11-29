using UnityEngine;
using System.Collections;

public class EquatonText : MonoBehaviour
{
    public GUISkin skin;

    void OnGUI()
    {
        GUI.skin = skin;

        if (Application.loadedLevel == 5)
        {
            GUI.Label(new Rect(300, 225, 1200, 1000), "Concentration NaOH *   Volume NaOH    = Concentration HCl * Volume HCl\n\n\n" +
                                                     "    0.1M NaOH          * Vol NaOH Titrated =        \"x\"M HCl        * 25.0mL HCl\n\n\n" +
                                                     "                      x = (0.1M NaOH * Vol NaOH Titrated) / 25.0mL HCl");
        }
    }

}
