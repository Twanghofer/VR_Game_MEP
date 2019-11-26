﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildungScript : MonoBehaviour
{
    public GameObject[] holoPosObj;
    public GameObject[] Objects;

    float distanceObj0 = 10;
    float distanceObj1 = 10;
    float distanceObj2 = 10;

    float snapDistance = 0.25F;

    public Animation anim;

    void Update()
    {
        distanceObj0 = Vector3.Distance(holoPosObj[0].transform.position, Objects[0].transform.position);
        distanceObj1 = Vector3.Distance(holoPosObj[1].transform.position, Objects[1].transform.position);
        distanceObj2 = Vector3.Distance(holoPosObj[2].transform.position, Objects[2].transform.position);

        if (distanceObj0 < snapDistance)
        {
            Objects[0].transform.position = holoPosObj[0].transform.position;
            Objects[0].transform.rotation = holoPosObj[0].transform.rotation;
            Objects[0].GetComponent<Rigidbody>().isKinematic = true;
            Objects[0].GetComponent<Collider>().enabled = false;
            holoPosObj[0].SetActive(false);
        }

        if (distanceObj1 < snapDistance)
        {
            Objects[1].transform.position = holoPosObj[1].transform.position;
            Objects[1].transform.rotation = holoPosObj[1].transform.rotation;
            Objects[1].GetComponent<Rigidbody>().isKinematic = true;
            Objects[1].GetComponent<Collider>().enabled = false;
            holoPosObj[1].SetActive(false);
            anim.Play("Spin");
        }

        if (distanceObj2 < snapDistance)
        {
            Objects[2].transform.position = holoPosObj[2].transform.position;
            Objects[2].transform.rotation = holoPosObj[0].transform.rotation;
            Objects[2].GetComponent<Rigidbody>().isKinematic = true;
            Objects[2].GetComponent<Collider>().enabled = false;
            holoPosObj[2].SetActive(false);

        }
    }
    
}
