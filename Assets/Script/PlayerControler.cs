using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 14.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        //Terminos eje horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        //Termino eje vertical
        verticalInput = Input.GetAxis("Vertical");

        //Movimiento hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        //Movimiento lateral
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        //Rotate
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
