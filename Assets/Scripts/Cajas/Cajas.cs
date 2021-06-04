using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajas : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CajaRed")
        {
            Destroy(gameObject);
        }
    }
}
