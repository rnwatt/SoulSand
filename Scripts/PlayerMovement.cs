using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//singleton pattern for player
//prototype pattern for enemies
public class PlayerMovement : MonoBehaviour
{
   Rigidbody2D body;
   float horizontal;
   float vertical;
   public Animator animator;
   public float runSpeed = 6f;
   public float diagonalLimit = 0.7f;
   public static bool key = false;
void Start ()
{
   body = GetComponent<Rigidbody2D>();
}

void Update()
{
   // Gives a value between -1 and 1
   horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
   vertical = Input.GetAxisRaw("Vertical"); // -1 is down
   if(horizontal != 0){
      animator.SetFloat("Speed", Mathf.Abs(horizontal));
   }
   if(vertical != 0)
   {
   animator.SetFloat("Speed", Mathf.Abs(vertical));
   }

   if(vertical == 0 && horizontal == 0)
   {
       animator.SetFloat("Speed", Mathf.Abs(vertical));
   }
}

void FixedUpdate()
{
   if (horizontal != 0 && vertical != 0)
   {
      horizontal *= diagonalLimit;
      vertical *= diagonalLimit;
   }

   if(horizontal > 0)
   {
      gameObject.transform.localScale = new Vector3(4,4,1);
   }

   if(horizontal < 0)
   {
      gameObject.transform.localScale = new Vector3(-4,4,1);
   }

   body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
}

}
