using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public RacketMovement leftRacket, rightRacket;
    Rigidbody2D rb2;
    public float movSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();

        rb2.velocity = new Vector2(1, 0) * movSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //TagsMan tm = collision.gameObject.GetComponent<>
        TagsMan tm = collision.gameObject.GetComponent<TagsMan>();

        if (tm == null) return;

        TAGS tag = tm.selected_Tags;

        if(tag == TAGS.LEFT_WALL)
        {
            rightRacket.MakeScore();

        }
        else if (tag == TAGS.RIGHT_WALL)
        {
            leftRacket.MakeScore();
        }
        else if (tag == TAGS.LEFT_RACKET)
        {

            ComputeReturningVec(collision, 1);
        }
        else if (tag == TAGS.RIGHT_RACKET)
        {
            ComputeReturningVec(collision, -1);

        }

    }
    private void ComputeReturningVec(Collision2D collision, float x)
    {
        float a = transform.position.y - collision.transform.position.y;
        float b = collision.collider.bounds.size.y;

        float y = a / b;

        rb2.velocity = new Vector2(x, y) * movSpeed;

    }
}
