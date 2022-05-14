using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidBody2D;
    [SerializeField] FixedJoystick _joystick;
    [SerializeField] Animator _anim;

    [SerializeField] float moveSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidBody2D.velocity = new Vector2(_joystick.Horizontal * moveSpeed, _rigidBody2D.velocity.y);
    }
}
