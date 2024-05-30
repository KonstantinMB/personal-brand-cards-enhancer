using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instagram : MonoBehaviour
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
        string igUrl = "https://www.instagram.com/iamkonstantinn";
        Application.OpenURL(igUrl);
    }
}
