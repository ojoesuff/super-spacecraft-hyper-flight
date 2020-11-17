using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour
{
    public MovementDirection movementDirection;
    public int enemySpeed;
    public float detectWallRadius;
    public LayerMask enemyLayer;
    public GameObject enemyCentre;
    protected bool attackPlayer;

    protected void Start()
    {
        attackPlayer = false;
    }

    // Update is called once per frame
    protected void Update()
    {
        if (isCloseToObstacle(enemyLayer, detectWallRadius)) changeDirection();

        if(!attackPlayer)
        {
            switch (movementDirection)
            {
                case MovementDirection.UP:
                    moveVertical(enemySpeed);
                    break;
                case MovementDirection.DOWN:
                    moveVertical(-enemySpeed);
                    break;
                case MovementDirection.LEFT:
                    moveHorizontal(-enemySpeed);
                    break;
                case MovementDirection.RIGHT:
                    moveHorizontal(enemySpeed);
                    break;
            }
        }       
    }

    void moveHorizontal(int speed)
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
    void moveVertical(int speed)
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
    protected bool isCloseToObstacle(LayerMask obstacles, float detectObstacleRadius)
    {
        return Physics2D.OverlapCircle(enemyCentre.transform.position, detectObstacleRadius, obstacles);
    }
    void changeDirection()
    {
        enemySpeed = -enemySpeed;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(enemyCentre.transform.position, detectWallRadius);
    }
}

public enum MovementDirection
{
    UP, DOWN, LEFT, RIGHT
}