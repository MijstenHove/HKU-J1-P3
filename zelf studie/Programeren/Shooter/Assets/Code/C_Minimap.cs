using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Minimap : MonoBehaviour
{

    public Transform player;


	private void LateUpdate()
	{
		Vector3 newPos = player.position;
		newPos.y = transform.position.y;
		transform.position = newPos;

		transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y,0f);
	}

}
