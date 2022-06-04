using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody2D enemyRigidbody;
    [SerializeField] Transform groundCheckPosition;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Collider2D bodyCollider2D;
    
    [HideInInspector] public bool mustPatrol = true;
    bool mustTurn;

    void Update() {
        
        if(mustPatrol) {
            Patrol();
        }
    
    }

    void FixedUpdate() {
        if(mustPatrol) {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPosition.position, 0.1f, groundLayer);
        }
    }

    void Patrol() {
        if (mustTurn || bodyCollider2D.IsTouchingLayers(groundLayer))
        {
            Flip();
        }
        enemyRigidbody.velocity = new Vector2(moveSpeed * Time.fixedDeltaTime, enemyRigidbody.velocity.y);
    }

    void Flip() {
        mustPatrol = false;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
        moveSpeed *= -1;
        mustPatrol = true;
    }
    
    
}
