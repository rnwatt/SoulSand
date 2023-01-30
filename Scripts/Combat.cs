using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=sPiVz1k-fEs&ab_channel=Brackeys
public class Combat : MonoBehaviour
{
	public Animator animator;
	public Transform attackPoint;
	public float attackRange = 0.5f;
    [SerializeField] public float attackDamage;
[SerializeField] public float attackSpeed = 1f;
	public LayerMask enemyLayer;
    public float attackRate = 2f;
    public float healRate = 4f;
    float nextAttackTime = 0f;
    float nextHealTime = 0f;
    public HealthPlayer player;
    // Update is called once per frame
    public void AttackClick()
        {
            if(Time.time >= nextAttackTime)
            {
            Attack();
            nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    public void HealClick()
    {
        if(Time.time >= nextHealTime)
        {
            Heal();
            nextHealTime = Time.time +1f / healRate;
        }
    }
    void Update()
    {
        if(Time.time >= nextAttackTime)
            {
        if(Input.GetKeyDown(KeyCode.V))
        {
            Attack();
            nextAttackTime = Time.time + 1f / attackRate;
        }
            }
        if(Time.time >= nextHealTime)
        {
            if(Input.GetKeyDown(KeyCode.C))
            {
            Heal();
            nextHealTime = Time.time + 1f / healRate;
            }
        }
    }
    void Attack()
    {
     animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyScript>().TakeDamage(attackDamage);
        }
    }

    void Heal()
    {
    player.health = player.health + 5f;
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
