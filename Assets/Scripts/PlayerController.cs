using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidBody2D;
    [SerializeField] FixedJoystick _joystick;
    [SerializeField] Animator _anim;

    [SerializeField] float moveSpeed = 0;
    bool facingRight = true;
    
    void Update() {
      if(_rigidBody2D.velocity.x < 0 && facingRight) {
          FlipFace();
      } else if (_rigidBody2D.velocity.x > 0 && !facingRight) {
          FlipFace();
      }
    }
    void FixedUpdate()
    {
        _rigidBody2D.velocity = new Vector2(_joystick.Horizontal * moveSpeed, _rigidBody2D.velocity.y);
    }

    void FlipFace() {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }
}
