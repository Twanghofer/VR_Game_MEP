using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class flashLightScript : MonoBehaviour
{
    public TextMeshProUGUI hiddenObject1;
    public Image hiddenObject2;

    public Animation obj1_fade;

    public Animation obj2_fade;

    private void OnTriggerEnter(Collider trigger)
    {

        if (trigger.tag == "showToggleObject1")
        {
            hiddenObject1.enabled = true;
            obj1_fade.Play("fadeIn");
        }

        if (trigger.tag == "showToggleObject2")
        {
            hiddenObject2.enabled = true;
            obj2_fade.Play("fadeIn_symbol");
        }


    }

    private void OnTriggerStay(Collider trigger)
    {
        Debug.Log("Trigger STay");

        if (trigger.tag == "showToggleObject1")
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

        {
            if (trigger.tag == "showToggleObject1")
            {
                obj1_fade.Play("fadeOut");
            }

            if (trigger.tag == "showToggleObject2")
            {
                obj2_fade.Play("fadeOut_symbol");
            }
            Debug.Log("No objects targetted");
            //hiddenObject1.enabled = false;
            
            
           // hiddenObject2.enabled = false;

        }
    }

    private void Start()
    {
        hiddenObject1.enabled = false;
        hiddenObject2.enabled = false;

    }

    void Update()
    {
        Debug.Log("flashLightActive");
    }

}
