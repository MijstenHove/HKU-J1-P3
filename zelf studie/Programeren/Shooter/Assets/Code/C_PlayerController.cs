using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_PlayerController : MonoBehaviour
{
    public float f_mouseSensitivety = 100f;
    public float speed = 0.1f;
    float angleX;
    float angleY;

    CharacterController controller;

    public Transform camara;


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
       
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Lookingaround();
        movingplayer2();
    }

    public void Lookingaround() 
    {
        float mouseX = Input.GetAxis("Mouse Y");
        float mouseY = Input.GetAxis("Mouse X");

        angleX += mouseX * f_mouseSensitivety * Time.deltaTime;
        angleY += mouseY * f_mouseSensitivety * Time.deltaTime;


        angleX = Mathf.Clamp(angleX, -90f, 90f);

        transform.rotation = Quaternion.Euler(-angleX, angleY, 0);
   
    }
    //movement with character controler v1 
    public void movingplayer()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            var a = transform.TransformDirection(0, 0, 50); //voor
            controller.SimpleMove(a * speed);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            var b = transform.TransformDirection(0, -50, 0); // achter
            controller.SimpleMove(b * speed);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            var c = transform.TransformDirection(50, 0, 0); //right
            controller.SimpleMove(c * speed);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            var d = transform.TransformDirection(-50, 0, 0); //link
            controller.SimpleMove(d * speed);
        }
    }

    //movement with character controler v2  breaky
    public void movingplayer2()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

    }



}
