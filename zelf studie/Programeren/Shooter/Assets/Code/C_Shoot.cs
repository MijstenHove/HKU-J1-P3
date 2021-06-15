using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Shoot : MonoBehaviour
{
    public float damage = 10;
    public float range = 100;

    public float impactforce = 30;
    public Camera fpsCam;
    public ParticleSystem gunflash;
    public GameObject inpect;

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
            
            print("hit") ;
            C_Target target = hit.transform.GetComponent<C_Target>();
            if (target != null) 
            {
                target.Damage(damage);
            }

            if (hit.rigidbody != null) 
            {
                hit.rigidbody.AddForce(-hit.normal * impactforce);
            
            }

            GameObject impactgo = Instantiate(inpect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactgo, 3f);

        }
    }
}
