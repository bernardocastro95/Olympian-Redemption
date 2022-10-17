﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
    public Rigidbody2D r2d;
    public float speed;
    public Transform player;
    private SpriteRenderer sRenderer;
    public Animator animator;

    public void Awake()
    {
        this.sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(speed));
        move();
        this.sRenderer.flipX = player.transform.position.x > this.transform.position.x;

        if(player.transform.position.x > this.transform.position.x)
        {
            speed *= -1;
        }
        
    }


    void move()
    {
        r2d.velocity = new Vector2(speed * Time.fixedDeltaTime, r2d.velocity.y);
    }

}
