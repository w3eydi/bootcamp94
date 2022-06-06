using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speedOfProjectile;

    Transform player;
    Vector2 target;

    void Start()
    {
        player = GameObject.Find("Character").transform;
        target = new Vector2(player.position.x, player.position.y);    
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speedOfProjectile * Time.deltaTime);
        
        if(transform.position.x == target.x && transform.position.y == target.y) {
            DestroyProjectile();
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Character") {
            DestroyProjectile();
        }
    }

    void DestroyProjectile() {
        Destroy(gameObject);
    }
}
