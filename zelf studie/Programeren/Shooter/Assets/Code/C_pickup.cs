using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_pickup : MonoBehaviour
{
	public GameObject player; 
	void OnCollisionEnter(Collision collision) 
	{
		print(collision.collider.name);
		C_Shoot pickup = collision.transform.GetComponent<C_Shoot>();

		if (pickup != null)
		{
			pickup.damage = pickup.damage + 10;
			Destroy(gameObject);
		}

	}
}
