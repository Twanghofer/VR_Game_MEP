using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketballScript : MonoBehaviour
{
    bool solvedPuzzle = false; 
    int currentGoals = 0;
    int requiredGoals = 3;

    public GameObject hoop1;
    public GameObject hoop2;
    public GameObject hoop3;

    public string hoopTag;


    private void OnTriggerEnter(Collider trigger)
    {

        if (trigger.tag == "hoop1")
        {
            Debug.Log(hoopTag);
            currentGoals += 1;
            Destroy(hoop1.gameObject.GetComponent<Collider>());
        }

    }

    private void Update()
    {
        if (currentGoals == requiredGoals)
        {
            solvedPuzzle = true;
        }

    }
}
