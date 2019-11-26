using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class symbol_puzzle : MonoBehaviour
{
    public Animation door_anim;

    private void OnTriggerStay(Collider trigger)
    {
        Debug.Log("Symbols are trigger");
        if (trigger.tag == "hand")
        {
            Debug.Log("hand is triggering symbols");
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("Open door");
                door_anim.Play("door_animation");
            }
        }

    }
}
