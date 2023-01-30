using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;
 //unity scriptable objects 
public class HealthPlayer : MonoBehaviour
{
    public float health = 0f;
    [SerializeField] static float maxHealth = 100f;

    [SerializeField] private Slider healthSlider;
    public PlayerMovement movement;
    GameObject gameData;
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
    		movement.enabled = false;
    		FindObjectOfType<GameManager>().GameOver();
    		Debug.Log("Health 0");
    	}
    }


    private void OnGUI()
    {
    	float t = Time.deltaTime / 1f;
    	healthSlider.value = health;
    }
}
