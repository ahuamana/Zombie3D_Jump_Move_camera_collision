﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed;
    public bool facingRight = true;
    public float moveDireccion;
    private new Rigidbody rigidbody;

    //public float jumpSpeed = 500.0f;

    //public bool grounded = false;
    //public Transform groundedCheck;
    //public float groundRadious = 0.2f;
    //public LayerMask whatIsground;

    //public float knifeSpeed = 500.0f;
    //public Transform knifeSpawn;
    //public Rigidbody knifePrefab;
    //Rigidbody clone;

    //void Attack() {

    //    clone = Instantiate(knifePrefab, knifeSpawn.position, knifeSpawn.rotation) as Rigidbody;
    //    clone.AddForce(knifeSpawn.transform.right * knifeSpeed);
    //}
    

    //animaciones
    //private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        //anim = GetComponent<Animator>();
        //groundedCheck = GameObject.Find("Groundcheck").transform;
        //knifeSpawn = GameObject.Find("KnifeSpawn").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDireccion = Input.GetAxis("Horizontal");


        //if (Input.GetButtonDown("Jump") && grounded)
        //{
        //    //rigidbodyConstraints = RigidbodyConstraints.None;
        //    rigidbody.AddForce(new Vector2(0, jumpSpeed));
        //    //animacion salto
        //    anim.SetTrigger("isJumping");
        //}
    }

    private void FixedUpdate()
    {
        //grounded = Physics2D.OverlapCircle(groundedCheck.position, groundRadious, whatIsground);
        ////rigidbodyConstraints = RigidbodyConstraints.FreezePositionY;

        rigidbody.velocity = new Vector2(moveDireccion*maxSpeed,rigidbody.velocity.y);


        if (moveDireccion > 0.0f && !facingRight)
        {
            Flip();

        } else {

            if (moveDireccion < 0.0f && facingRight)
            {
                Flip();
            }

        }

        ////asignar la velocidad
        ////moveDireccion solo devuelve si positivo si avanza y negativo si no avanza
        //anim.SetFloat("Speed", Mathf.Abs(moveDireccion));

        //if (Input.GetButtonDown("Fire1"))
        //{

        //    Attack();
        //}

        //Debug.Log("DatoVelocidad: "+ Mathf.Abs(moveDireccion));

    }

        void Flip() {
        facingRight = !facingRight; //si esta mirando
        transform.Rotate(Vector3.up,180.0f, Space.World);//gira al eje y
        //transform.Rotate(new Vector3(0,1,0), 180.0f, Space.World);//gira al eje y
    }

}
