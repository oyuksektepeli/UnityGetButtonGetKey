using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Standard");
    }

    // Update is called once per frame
    void Update()
    {
        //Input is evaluated and stored in Input and callded before Update event.
        bool down = Input.GetButtonDown("Space");
        bool held = Input.GetButton("Space");
        bool up = Input.GetButtonUp("Space");

        if (down)
        {
            Debug.Log("Down");
        }
        else if (held)
        {
            Debug.Log("Held");
        }
        else if (up)
        {
            Debug.Log("up");
        }
        else
        {
            Debug.Log("Standard");
        }

    }
}
