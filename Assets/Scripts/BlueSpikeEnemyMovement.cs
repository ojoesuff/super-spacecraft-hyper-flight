using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpikeEnemyMovement : BasicEnemyMovement
{
    GameObject player;
    public LayerMask playerLayer;
    public float detectPlayerRadius;
    Vector2 playerPos;
    public float attackSpeed;
    void Start()
    {
        base.Start();
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        base.Update();
        if(isCloseToObstacle(playerLayer, detectPlayerRadius))
        {
            if(!attackPlayer)
            {
                attackPlayer = true;
                playerPos = player.transform.position;
            }
            moveTowardsPlayer(playerPos);
        } else
        {
            attackPlayer = false;
        }
    }

    void moveTowardsPlayer(Vector2 endPosition)
    {
        transform.position = Vector2.MoveTowards(transform.position, endPosition, attackSpeed * Time.deltaTime);
    }

    //if hit wall during this, stick to it (disable other wall detection)

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(enemyCentre.transform.position, detectPlayerRadius);
    }

}
