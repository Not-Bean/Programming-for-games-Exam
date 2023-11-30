using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // TODO make ball move only on X-Axis
    //Start game on LMB click
    //Change movement to X-Axis when LMB is clicked
    //Make ball fall off platform and cause a game over

    public float speed;
    public bool started;
    public bool falling;
    public bool gameOver;
    public bool changeAxis;

    Rigidbody rb;
    void Start()
    {
        Rigidbody rb = new Rigidbody();
    }

    void Update()
    {


        if (started == true && changeAxis == false)
        {
            transform.Translate(speed, 0, 0);//moves on x axis
        }
        if (started == true && changeAxis == true)
        {
            transform.Translate(0, 0, speed);//moves on z axis
        }
    }

    void Movement(int movement)
    {
        if(started)
        {
            
        }
        else
        {

        }
    }
    void FirstLMBClick()
    {
        if ()
        {

        }
    }

}
