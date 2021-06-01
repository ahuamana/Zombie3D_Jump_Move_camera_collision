using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirCaja : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Caja")
        {
            Destroy(collision.gameObject, 0.5f);
        }
    }
}
