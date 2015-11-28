using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static string inputText;

    public void GetInput(string guess)
    {
        Debug.Log(guess);
        inputText = guess;
    }
	
}
