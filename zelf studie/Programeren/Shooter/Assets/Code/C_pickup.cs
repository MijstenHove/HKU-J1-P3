using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_pickup : MonoBehaviour
{
	public float damageAmount;
	void OnCollisionEnter(Collision collision)
	{
		print("this is colilding " + collision.collider.name);
		C_Shoot player_ = collision.transform.GetComponent<C_Shoot>();

		if (collision.gameObject.tag == "Player")
		{
			player_.damage = player_.damage + 20;
			Destroy(gameObject);
		}

	}
	void OnCollisionStay(Collision collision)
	{
		print("this is staying " + collision.collider.name);
	}
}
