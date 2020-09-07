using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("standard");
    }

    // Update is called once per frame
    //Input is evaluated and stored in Input and callded before Update event.

    //KeyUp - There was an up event for this key between this frame and the last
    //KeyDown - There was a down event for this key in between this frame and the last
    //Key - There has previously been a KeyDown event for this key, but no KeyUp yet

    //same as button


    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

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
