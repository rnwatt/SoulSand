using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEntrance : MonoBehaviour
{
	PlayerMovement player;
   private void OnCollisionStay2D(Collision2D other)
	{
   		if(other.gameObject.tag != "Enemy")
   		{
      FindObjectOfType<GameManager>().BossArena();
   		}
	}
}
