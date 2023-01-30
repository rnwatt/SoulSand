using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;
 //https://www.youtube.com/watch?v=kOzhE3_P2Mk&ab_channel=AlexanderZotov Source
public class Boss : MonoBehaviour
{
    float health;
    public float damage = 15f;
    [SerializeField] private float attackRate;
    public Animator animator;
    [SerializeField] GameObject fireball;
    private void Start()
    {
    	animator = GetComponent<Animator>();
        ShootFire();
        attackRate = Time.time;
        Debug.Log(attackRate);
        
    }

    private void Update()
    {
        if (attackRate < 0)
        {
            attackRate = 30f;
            ShootFire();
        }

    	if (attackRate > 0)
    	{
    		attackRate -= 0.5f;
    	}
        ShootFire();
    }

    void ShootFire()
    {
        if(attackRate == 0)
        {
            Instantiate(fireball, transform.position, Quaternion.identity);
            attackRate =+ 30f;
        }
    }
}
