using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Player : MonoBehaviour
{
    public float speed = 10;

    Vector2 velocity;

    public AudioClip[] choques;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition(GetInput());
    }

    void UpdatePosition(Vector2 input) {
        Vector2 direction = input.normalized;
        velocity = direction * speed;
        Vector2 moveAmount = velocity * Time.deltaTime;

        transform.Translate(moveAmount);
    }

    Vector2 GetInput() {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        return input;
    }

    void OnCollisionEnter2D() {
        audioSource.clip = choques[Random.Range(0, choques.Length)];
        audioSource.Play(0);
    }
}
