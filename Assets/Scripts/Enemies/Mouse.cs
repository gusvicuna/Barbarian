using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [Header("Movement Settings:")]
    public float speed = 3;
    public float fleespeed = 5;
    [Range(0,90)]
    public float wanderangle = 5;

    Vector2 velocity;
    Vector2 desired_velocity;
    Vector2 direction;

    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Vector2 input = new Vector2(0, 1);
        direction = input.normalized;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 wanderVector = (Quaternion.AngleAxis(wanderangle, Vector2.right) * Vector2.up).normalized;
        direction = (direction + wanderVector).normalized;
        velocity = direction * speed;
    }

    private void FixedUpdate() {
        Move();
    }
    void Move() {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.deltaTime);
    }
}
