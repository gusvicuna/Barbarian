using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    public AudioClip[] choques;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayerPhysicsController.OnHitEvent += PlayerCrash;
    }

    void OnDisable() {
        PlayerPhysicsController.OnHitEvent += PlayerCrash;
    }

    void PlayerCrash(){
        audioSource.clip = choques[Random.Range(0, choques.Length)];
        audioSource.Play(0);
    }
}
