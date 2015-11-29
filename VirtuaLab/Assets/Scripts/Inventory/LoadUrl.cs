using UnityEngine;
using System.Collections;

public class LoadUrl : MonoBehaviour {

    public static string url;
    public static WWW request;
    public GUISkin skin;

    IEnumerator Start ()
    {

        url = "file:///" + Application.dataPath + "/StreamingAssets/Items.json"; //take out file:/// when building webplayer.
        request = new WWW(url);
        yield return request;
        Debug.Log(url);
        Debug.Log(request.text);
    }

}
