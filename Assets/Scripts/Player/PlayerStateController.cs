using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour
{
    public float speed = 10;

    Vector2 velocity;
    PlayerInputController input;

    // Start is called before the first frame update
    void Start()
    {
        input = transform.GetComponent<PlayerInputController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdatePosition(input.direction);
    }

    void UpdatePosition(Vector2 input) {
        Vector2 direction = input.normalized;
        velocity = direction * speed;
        Vector2 moveAmount = velocity * Time.deltaTime;

        transform.Translate(moveAmount);
    }
}
