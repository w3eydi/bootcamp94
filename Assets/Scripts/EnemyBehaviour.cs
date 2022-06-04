using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
   [SerializeField] float moveSpeed;
    
    [HideInInspector] public bool mustPatrol;
   /*bool movingRight = true;
   float distance = 2f;

   [SerializeField] Transform groundDetection;
    */
   void Update() {
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       /*transform.Translate(Vector2.right * moveSpeed * Time.deltaTime, 0f);
       RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false && movingRight == true)
        {
            transform.rotation = new Vector3(0, -180, 0);
            movingRight = false;
        } else if (groundInfo.collider == false && movingRight == false) {
            transform.eulerAngles = new Vector3(0, 0, 0);
            movingRight = true;
        }*/
   } 
    
    
    
    
    
    
    
    
    /*
    [SerializeField] float moveSpeed = 25f;

    Rigidbody2D enemyRigidbody;
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            enemyRigidbody.velocity = new Vector2(-moveSpeed * Time.deltaTime, 0f);
        } else
        {
            enemyRigidbody.velocity = new Vector2(moveSpeed * Time.deltaTime, 0f);
        }
    }

    private bool IsFacingRight() {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D other) {
        transform.localScale = new Vector2(-(Mathf.Sign(enemyRigidbody.velocity.x)), transform.localScale.y);
    }*/
}
