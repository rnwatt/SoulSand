using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=kOzhE3_P2Mk&ab_channel=AlexanderZotov
public class Bullet : MonoBehaviour
{
	float fireSpeed = 5f;
	Rigidbody2D rb;
	PlayerMovement target;
	Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * fireSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.gameObject.tag == "Player")
    	{
    		Debug.Log("Hit by fire");
    		other.gameObject.GetComponent<HealthPlayer>().UpdateHealth(-30f);
    		Destroy (gameObject);
    	}
    }
}
