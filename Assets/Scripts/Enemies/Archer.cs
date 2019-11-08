using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    [Header("Arrow Spawn Settings:")]
    public GameObject arrowPrefab;
    public float rate = 2;
    public float range = 2;

    Vector2 start;

    GameObject newArrow;
    float nextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        nextSpawn = 0;
    }

    // Update is called once per frame
    void Update() {
        if (Time.time > nextSpawn) {
            DestroyArrow(newArrow);
            CreateArrow();
        }
    }

    void CreateArrow() {
        
        nextSpawn += rate;

        Vector2 randomSpawnPosition = new Vector2(Random.Range(start.x - range, start.x + range), Random.Range(start.y - range, start.y + range));
        Vector2 randomSpawnRotation = Vector2.up;

        newArrow = Instantiate(arrowPrefab, randomSpawnPosition, Quaternion.Euler(randomSpawnRotation));
    }
    void DestroyArrow(GameObject arrow) {
        if (arrow != null) {
            Destroy(arrow);
        }
    }
}
