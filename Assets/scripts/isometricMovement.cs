using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isometricMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rigid;
    

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
      rigid.MovePosition(rigid.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
     private void OnCollisionEnter2D(Collision2D other)
   {
     if (other.gameObject.CompareTag("pickup"))
     {
         FindObjectOfType<AudioManager>().Play("pickup");
         Destroy(other.gameObject);
     }  
   }
}

