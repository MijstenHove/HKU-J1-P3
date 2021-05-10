using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Shoot : MonoBehaviour
{
    public float damage = 10;
    public float range = 100;
    public Camera fpsCam;
    public ParticleSystem gunflash;

	// raykast 
	// patical 


	private void Start()
	{
       
	}
	void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gunflash.Play();
            Shoot();
        }
    }
    public void Shoot() 
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            // play partical
            
            Debug.Log(hit.transform.name);
        }
    }
}
