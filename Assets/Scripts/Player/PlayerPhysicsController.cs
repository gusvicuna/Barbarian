using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysicsController : MonoBehaviour
{
    public static event System.Action OnHitEvent;
    public static event System.Action OnFinishEvent;
    public static event System.Action OnDeadEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
            OnHitEvent?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Finish") {
            OnFinishEvent?.Invoke();
        }
        else if (collision.tag == "Enemy") {
            OnDeadEvent?.Invoke();
        }
    }
}
