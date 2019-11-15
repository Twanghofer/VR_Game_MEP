using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class flashLightScript : MonoBehaviour
{
    public TextMeshProUGUI hiddenObject1;
    public Image hiddenObject2;

    private void OnTriggerEnter(Collider trigger)
    {
        Debug.Log("Collision enter");

        /*if (trigger.tag == "showToggleObject1")
        {
            hiddenObject1.enabled = true;
            Debug.Log("Object 1 is targetted");
        }

        if (trigger.tag == "showToggleObject2")
        {
            hiddenObject2.enabled = true;
            Debug.Log("Object 2 is targetted");
        }
    }

    private void OnTriggerExit(Collider trigger)
    {
        Debug.Log("Collision enter");

        if (trigger.tag == "showToggleObject1")
        {
            hiddenObject1.enabled = false;
        }

        if (trigger.tag == "showToggleObject2")
        {
            hiddenObject2.enabled = false;
        }*/
    }

    void Update()
    {
        Debug.Log("flashLightActive");
    }

}
