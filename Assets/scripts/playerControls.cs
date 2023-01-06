using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float regularSpeed = 20f;
    bool canMove = true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        canMove = true;
    }

    void Update()
    {
      if (canMove) {
        rotatePlayer();
        respondToBoost();
      }
    }

    public void disableControls() {
      canMove = false;
    }
    void respondToBoost()
    {
      if (Input.GetKey(KeyCode.W))
      {
        surfaceEffector2D.speed = boostSpeed;
      }
      else {
        surfaceEffector2D.speed = regularSpeed;
      }
    }

    void rotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
