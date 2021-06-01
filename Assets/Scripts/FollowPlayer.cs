using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject cameraFirstPerson;
    public GameObject mainCamera;
    private Vector3 offset = new Vector3(-5, 3f, 0f);
    private Vector3 offsetfirstcamera = new Vector3(0, 2f, 0f);
    private bool iskeyPress = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (iskeyPress)
        {
            mainCamera.SetActive(true);
            cameraFirstPerson.SetActive(false); ////camera firsperson deshabilida
            mainCamera.transform.position = player.transform.position + offset; //new vector 3 = es el offset
            //Debug.Log("camara principal");
        }

        if (Input.GetKey(KeyCode.F))
        {
            if (iskeyPress == true)
            {
                iskeyPress = false;
            }
            else
            {
                iskeyPress = true;
            }

        }

        if (!iskeyPress)
        {
            cameraFirstPerson.SetActive(true);
            mainCamera.SetActive(false);//camera principal deshabilida
            cameraFirstPerson.transform.position = player.transform.position + offsetfirstcamera;


        }
    }

  
}
