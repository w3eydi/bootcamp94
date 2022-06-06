using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] float speedOfBoss;
    [SerializeField] float stoppingDistance;
    [SerializeField] float stepBackDistance;

    [SerializeField] Transform player;
    [SerializeField] GameObject projectile;

    float timeBetweenShots;
    [SerializeField] float startTimeBetweenShots;
    void Start()
    {
        timeBetweenShots = startTimeBetweenShots;
    }

    void Update()
    {
        if (Score.bossTrigger == true) {
            if (Vector2.Distance(transform.position, player.position) > stoppingDistance) {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speedOfBoss * Time.deltaTime);
            } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance
            && Vector2.Distance(transform.position, player.position) > stepBackDistance) {
                transform.position = this.transform.position;
            } else if (Vector2.Distance(transform.position, player.position) < stepBackDistance) {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speedOfBoss * Time.deltaTime);
            }

            if(timeBetweenShots <= 0) {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBetweenShots = startTimeBetweenShots;
            } else {
                timeBetweenShots -= Time.deltaTime;
            }
        }
    }
}
