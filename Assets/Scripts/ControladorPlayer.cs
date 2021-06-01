using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer : MonoBehaviour
{
    public CharacterController controller;

    public float speed;
    public float gravedad;
        public Vector3 direccion;
    public float rotspeed = 5f;
    public float rotacion;
    public float salto = 10f;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        speed = 15;
        gravedad = 9.8f;
    }

    // Update is called once per frame
    void Update()
    {
        //direccion = Vector3.zero;
        //direccion.y -= gravedad * Time.deltaTime;
        //direccion.x = Input.GetAxis("Horizontal") * speed;
        //direccion.z = Input.GetAxis("Vertical") * speed;
        //controller.SimpleMove(Vector3.right * speed * Time.deltaTime);
        //controller.Move(direccion * Time.deltaTime);

        direccion = gameObject.transform.TransformDirection(new Vector3(Input.GetAxis("Vertical"),0,0) * speed);
        rotacion = Input.GetAxis("Horizontal") * rotspeed;
        direccion -= new Vector3(0, gravedad * Time.deltaTime,0);
        controller.transform.Rotate( new Vector3(0f,rotacion,0f));
        controller.Move(direccion * Time.deltaTime);

        //salto
        if (Input.GetKeyDown(KeyCode.M))
        {
            direccion.y += salto * Time.deltaTime * speed;
        }


    }
}
