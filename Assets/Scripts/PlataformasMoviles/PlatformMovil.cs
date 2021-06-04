using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovil : MonoBehaviour
{

    public Rigidbody platformRB;
    public Transform[] platformPositions;
    public float platformSpeed;

    private int actualPosition = 0;
    private int nextPosition = 1;

    
    void Update()
    {
        MovePlatform();
    }

    private void MovePlatform()
    {
        //Move current position to a target
        platformRB.MovePosition(Vector3.MoveTowards(platformRB.position, platformPositions[nextPosition].position, platformSpeed * Time.deltaTime));

        //Calcula la distancia entre dos vectores
        if (Vector3.Distance(platformRB.position, platformPositions[nextPosition].position) <= 0)
        {
            actualPosition = nextPosition;
            nextPosition++;

            //
            if (nextPosition > platformPositions.Length - 1)
            {
                nextPosition = 0;
            }

        }

    }
}
