using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    Vector2 start;
    public GameObject arrowPrefab;
    float rate;

    GameObject newArrow;
    float nextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        rate = 10/eye.speed;
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

        Vector2 randomSpawnPosition = new Vector2(Random.Range(start.x - 3, start.x + 3), Random.Range(start.y - 3, start.y + 3));
        Vector2 randomSpawnRotation = Vector2.up;

        newArrow = Instantiate(arrowPrefab, randomSpawnPosition, Quaternion.Euler(randomSpawnRotation));
    }
    void DestroyArrow(GameObject arrow) {
        if (arrow != null) {
            Destroy(arrow);
        }
    }
}
