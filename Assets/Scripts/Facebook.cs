using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facebook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        OpenFacebook();
    }

    public void OpenFacebook()
    {
        string fbUrl = "https://www.facebook.com/konstantin.borimechkov";
        Application.OpenURL(fbUrl);
    }
}
