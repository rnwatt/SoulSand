using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	bool key = false;
 	void OnTriggerEnter(Collider other)
 	{
 		if (other.gameObject.tag == "Player")
 		{
 			key = true;
 			Destroy(gameObject);
 		}
 	}
}
