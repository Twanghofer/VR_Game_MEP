using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class flashLightScript : MonoBehaviour
{
    public TextMeshProUGUI hiddenObject1;
    public Image hiddenObject2;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "showToggleObject1")
        {
            hiddenObject1.enabled = false;
            Debug.Log("Object 1 is targetted");
        }

        if (collision.collider.tag == "showToggleObject2")
        {
            hiddenObject2.enabled = false;
            Debug.Log("Object 2 is targetted");
        }
    }


}
