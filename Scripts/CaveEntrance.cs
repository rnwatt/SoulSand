using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CaveEntrance : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
{
   if(other.gameObject.tag != "Enemy")
   {
      FindObjectOfType<GameManager>().DungeonMap();
   }
}
}
