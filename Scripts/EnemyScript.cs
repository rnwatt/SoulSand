using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Resource - https://youtu.be/b0O71Wa09nI
https://www.youtube.com/watch?v=VOdYtqV_meo&ab_channel=MuddyWolf Sources
*/
public class EnemyScript : MonoBehaviour
{
   public float speed = 0.03f;
   public Transform target;
   public float range;
   private Rigidbody2D body;
   GameObject spawner;
   GameObject boss;
   float horizontal;
   float vertical;
   [SerializeField] private float attackDamage;
   [SerializeField] private float attackSpeed;
   private float canAttack;
   public Animator animator;
   public float maxHealth;
   public float health;
   private void Start()
   {
      body = GetComponent<Rigidbody2D>();
      health = maxHealth;
      boss = GameObject.FindWithTag("EnemyB");
      spawner = GameObject.FindWithTag("Spawner");
      
   }
private void Update()
{
   float distance = Vector2.Distance(target.position, transform.position);
   if (distance <= range)
   {
      transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed);   
   }
   if(boss == null)
      {
         FindObjectOfType<GameManager>().VictoryScreen();
      }
}

   public void TakeDamage(float attackDamage)
   {
      health = health - attackDamage;
      animator.SetTrigger("Hurt");
      if(health <=0)
      {
         health = 0f;
         EnemyDeath();
      }
   }

   void EnemyDeath()
   {

      this.enabled = false;
      animator.SetBool("isDead", true);
      Destroy(gameObject);
      spawner.GetComponent<EnemySpawn>().counter--;
      spawner.GetComponent<EnemySpawn>().enemyDead = true;
   
   }

   private void OnCollisionStay2D(Collision2D other)
   {
      if (other.gameObject.tag == "Player")
      {
         if(attackSpeed <= canAttack)
         {
            animator.SetBool("isAttack", true);
         other.gameObject.GetComponent<HealthPlayer>().UpdateHealth(-attackDamage);
         canAttack = 0f;
       
         } else {
            animator.SetBool("isAttack", false);
            canAttack += Time.deltaTime;
         }
      }
   }
}
