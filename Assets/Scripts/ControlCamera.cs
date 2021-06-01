using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    private GameObject player;
    public Vector3 distancia;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        distancia = new Vector3(0, -1.5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.transform.position - distancia;
    }
}
