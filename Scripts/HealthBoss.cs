using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;
public class HealthBoss : MonoBehaviour
{
    public float health = 0f;
    [SerializeField] public float maxHealth = 100f;
    [SerializeField] private Slider healthSlider;
 
 	private void Start()
    {
    	healthSlider.maxValue = maxHealth;
    	health = maxHealth;
    }

    public void UpdateHealth(float mod)
    {
    	health += mod;

    	if (health > maxHealth)
    	{
    		health = maxHealth;
    	} else if (health <= 0f)
    	{
    		health = 0f;
    		
    		FindObjectOfType<GameManager>().VictoryScreen();
    		Debug.Log("Boss dead");
    	}
    }


    private void OnGUI()
    {
    	float t = Time.deltaTime / 1f;
    	healthSlider.value = health;
    }
}
