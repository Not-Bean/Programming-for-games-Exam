using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BallController : MonoBehaviour
{
    //TODO


    public float speed = 0.005f;
    public float fallDelay = 5.0f;
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
        CheckIfFalling();
        FirstLMBClick();
        ChangeAxis();
        Movement();
    

    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(fallDelay);
    }
 

    void Movement()
    {
        if (started && !falling)
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
    }
    void FirstLMBClick()
    {
        if (!started )
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                started = true;
            }
            //check for LMB click
        }
    }
    void ChangeAxis()
    {
        if (started && !falling && !gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                changeAxis = !changeAxis;
            }
            
            //check for LMB click
        }
    }
    void CheckIfFalling()
    {
        if (GameObject.FindGameObjectWithTag("Player") && !gameOver)
        {
            if (transform.position.y < 0.0)
            {
                falling = true;
                
            }
            if (falling == true && started == true)
            {
                StartCoroutine("Delay");
                Destroy(GameObject.FindGameObjectWithTag("Player"));
                gameOver = true;
            }

        }
    }

}
