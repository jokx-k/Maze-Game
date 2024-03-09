using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour

{
    public float spawnRate = 1f;
    public GameObject hexagonprefab;
    private float nextTimeTospawn=0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=nextTimeTospawn)
        {
            Instantiate(hexagonprefab, Vector3.zero, Quaternion.identity);
            nextTimeTospawn = Time.time + 1f / spawnRate;
        }
    }
}
