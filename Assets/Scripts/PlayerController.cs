using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidBody2D;
    [SerializeField] FixedJoystick _joystick;
    [SerializeField] Animator _anim;

    [SerializeField] Canvas _touchCanvas;
    [SerializeField] GameObject _gameOver;

    [SerializeField] float moveSpeed = 0;
    [SerializeField] float jumpPower = 1f;
    float jumpFrequency = 0.1f, nextJumpTime;
    bool facingRight = true;
    bool isGrounded = false;
    [SerializeField] Transform groundCheckPosition;
    [SerializeField] float groundCheckCircle;
    [SerializeField] LayerMask groundCheckLayer;
    
    void Update() {
      if(_rigidBody2D.velocity.x < 0 && facingRight) {
          FlipFace();
      } else if (_rigidBody2D.velocity.x > 0 && !facingRight) {
          FlipFace();
      }

      OnGroundCheck();
    }
    void FixedUpdate()
    {
        HorizontalMove();
    }

    void HorizontalMove() {
        _rigidBody2D.velocity = new Vector2(_joystick.Horizontal * moveSpeed, _rigidBody2D.velocity.y);
        _anim.SetFloat("playerSpeed", Mathf.Abs(_rigidBody2D.velocity.x));
    }

    public void Jump() {
        if(isGrounded && (nextJumpTime < Time.timeSinceLevelLoad)) {
            nextJumpTime = Time.timeSinceLevelLoad + jumpFrequency;
            _rigidBody2D.AddForce(new Vector2(0f, jumpPower));
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().JumpAudio();
        }
    }

    void FlipFace() {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }

    void OnGroundCheck() {
        isGrounded = Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckCircle
        , groundCheckLayer);
        _anim.SetBool("isGroundedAnim", isGrounded);
       
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "DeathBarrier")
        {
            Time.timeScale = 0f;
            _gameOver.SetActive(true);
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().GameoverAudio();
            _touchCanvas.enabled = false;
        }
    }
}
