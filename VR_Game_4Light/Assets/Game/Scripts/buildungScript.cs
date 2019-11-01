﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildungScript : MonoBehaviour
{
    public GameObject[] holoPosObj;
    public GameObject[] Objects;

    float distanceObj0;
    float distanceObj1;
    float distanceObj2;

    float snapDistance = 0.25F;

    void Update()
    {
        distanceObj0 = Vector3.Distance(holoPosObj[0].transform.position, Objects[0].transform.position);
        distanceObj1 = Vector3.Distance(holoPosObj[1].transform.position, Objects[1].transform.position);
        distanceObj2 = Vector3.Distance(holoPosObj[2].transform.position, Objects[2].transform.position);

        if (distanceObj0 < snapDistance)
        {
            Objects[0].transform.position = holoPosObj[0].transform.position;
        }

        if (distanceObj1 < snapDistance)
        {
            Objects[1].transform.position = holoPosObj[1].transform.position;
        }

        if (distanceObj1 < snapDistance)
        {
            Objects[1].transform.position = holoPosObj[1].transform.position;
        }
    }
}
