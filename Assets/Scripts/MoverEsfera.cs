using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEsfera : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 direccion;
    public float speed = 10f;
    public float salto = 35f, saltoultimo, saltoduracion;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        direccion = Vector3.zero;
        saltoultimo = Time.time;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        direccion = new Vector3(Input.GetAxis("Horizontal"),0f, Input.GetAxis("Vertical"));

        if (Input.GetButtonDown("Jump"))
        {
            if ((Time.time - saltoultimo) > saltoduracion)
            {
                direccion.y += salto;
                saltoultimo = Time.time;
            }
            
        }

        rb.AddForce(direccion*speed* Time.deltaTime, ForceMode.Impulse);
    }
}
