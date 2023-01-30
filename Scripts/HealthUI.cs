using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
  private int health = 10;
  public Text healthText;
  void update()
  {
  	healthText.text = health.ToString();

  	if(Input.GetKeyDown(KeyCode.Space))
  	{
  		health--;
  	}
  }
}
