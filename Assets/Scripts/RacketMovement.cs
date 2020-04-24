using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class RacketMovement : MonoBehaviour
{

    public int Score { get; set; } = 0;
    public Text scoreText;
    public int movSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected abstract void Move();
     
    public void MakeScore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }

}
