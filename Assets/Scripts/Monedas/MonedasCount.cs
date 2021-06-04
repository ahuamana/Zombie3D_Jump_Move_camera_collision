using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedasCount : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Monedas")
        {
            Debug.Log("Colisono");

            Destroy(collision.gameObject, 0.1f);
        }
    }
}
