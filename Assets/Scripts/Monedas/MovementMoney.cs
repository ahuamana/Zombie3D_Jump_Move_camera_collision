﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMoney : MonoBehaviour
{


    public float speedMoneda;

    private void Start()
    {
        speedMoneda = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speedMoneda);
        
    }
}
