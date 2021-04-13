using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_PlayerController : MonoBehaviour
{
    public float f_moveSpeed;
    public float f_mouseSensitivety = 100f;
    float f_xrotation = 0f;
    float angleX;
    float angleY;

    public Transform camara;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Lookingaround();

    }

    public void Lookingaround() 
    {
        float mouseX = Input.GetAxis("Mouse Y");
        float mouseY = Input.GetAxis("Mouse X");

        angleX += mouseX * f_mouseSensitivety * Time.deltaTime;
        angleY += mouseY * f_mouseSensitivety * Time.deltaTime;


        angleX = Mathf.Clamp(angleX, -90f, 90f);

        transform.rotation = Quaternion.Euler(angleX, angleY, 0);
   
    }
    public void movingplayer()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

    
    }



}
