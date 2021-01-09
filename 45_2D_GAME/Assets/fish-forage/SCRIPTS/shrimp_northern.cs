﻿using UnityEngine;

public class shrimp_northern: MonoBehaviour
{
    private Rigidbody2D rb;

   public Transform leftpoint, rightpoint;
    public float Speed;
    private float leftx, rightx;

    public bool Faceleft = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.DetachChildren();
        leftx = leftpoint.position.x;
        rightx = rightpoint.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);
    }
    private void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (Faceleft)
        {
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
            if (transform.position.x <leftx)
            {
                transform.localScale = new Vector3(-1, 0.6f, 0.6f);
                Faceleft = false;
            }
        }
        else
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
            if (transform.position.x >rightx)
            {
                transform.localScale = new Vector3(1, 0.6f, 0.6f);
                Faceleft = true;
            }
        }
    }
}
