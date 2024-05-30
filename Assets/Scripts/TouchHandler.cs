using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                HandleTouch(touch.position);
            }
        }
    }

    void HandleTouch(Vector2 touchPosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(touchPosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform != null)
            {
                Debug.Log("Touched: " + hit.transform.name);

                if (hit.transform.CompareTag("facebook"))
                {
                    Application.OpenURL("https://www.facebook.com/p/%D0%91%D0%B0%D1%80-%D0%A1%D0%B0%D0%BC%D0%B0%D1%80-%D0%BD%D0%B0-%D0%BA%D0%BE%D0%BB%D0%B5%D0%BB%D0%B0-100076072987153/");
                }
                else if (hit.transform.CompareTag("instagram"))
                {
                    Application.OpenURL("https://www.instagram.com/bar_samar_na_kolela/");
                }
            }
        }
    }
}
