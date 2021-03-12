using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    private float bound = 2.55f;
    public GameObject bombPrefab;

    void Start()
    {
        StartCoroutine(SpawnBombs());
    }

    IEnumerator SpawnBombs()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(0f, 1f));
        Instantiate(bombPrefab, new Vector2(UnityEngine.Random.Range(-bound, bound), transform.position.y), Quaternion.identity);
        StartCoroutine(SpawnBombs());
    }

    void Update()
    {
        
    }
}
