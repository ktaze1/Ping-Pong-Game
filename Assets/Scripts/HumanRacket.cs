using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanRacket : RacketMovement
{

    public string axisname;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected override void Move()
    {
        float moveAxis = Input.GetAxis(axisname) * 7;

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveAxis);
    }

}
