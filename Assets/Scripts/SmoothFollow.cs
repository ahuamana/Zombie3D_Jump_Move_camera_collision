using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public float xMargin = 1.0f;
    public float yMargin = 1.0f;

    public float xSmooth = 10.0f;
    public float ySmooth = 10.0f;

    public Vector2 maxXandY;
    public Vector2 minXandY;

    public Transform cameraTarget;

    

    private void Awake()
    {
        cameraTarget = GameObject.FindGameObjectWithTag("CameraTarget").transform; // obtenemos la posicion de camera
    }

    bool CheckXmargin() {

        return Mathf.Abs(transform.position.x - cameraTarget.position.x) > xMargin;

    }

    bool CheckYmargin()
    {

        return Mathf.Abs(transform.position.y - cameraTarget.position.y) > yMargin;

    }

    private void FixedUpdate()
    {

        seguimientoPlayer();
    }

    private void seguimientoPlayer()
    {
        float targetx = transform.position.x;
        float targety = transform.position.y;

        if (CheckXmargin())
        {
            targetx = Mathf.Lerp(transform.position.x, cameraTarget.position.x, xSmooth * Time.deltaTime);
        
        }

        if (CheckYmargin())
        {
            targety = Mathf.Lerp(transform.position.y, cameraTarget.position.y, ySmooth * Time.deltaTime);

        }

        targetx = Mathf.Clamp(targetx, minXandY.x, maxXandY.x);
        targety = Mathf.Clamp(targety, minXandY.y, maxXandY.y);

        transform.position = new Vector3(targetx, targety, transform.position.z);
    }


}
