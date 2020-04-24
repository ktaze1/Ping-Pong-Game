using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : RacketMovement
{
    public Transform ball;
    protected override void Move()
    {
        float minDist = Mathf.Abs(ball.position.y - transform.position.y);
        if(minDist > 4)
        {
            if (ball.position.y > transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movSpeed;
            } 
        }
    }

}
