using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform Donut;
    [SerializeField] private float SpawnTime = 2;

    private float xPos;
    private float timer;
    private int randomspawn;

    private void Update()
    {
        timer += Time.deltaTime;

        xPos = UnityEngine.Random.Range(-2.66f, 3.2f);

        if (timer >= SpawnTime)
        { 
            CreateItem();

            timer = 0;

            randomspawn = UnityEngine.Random.Range(1, 50);
        }
    }
    private void CreateItem()
    {
        Instantiate(Donut, new Vector2(xPos, transform.position.y), Quaternion.identity);
    }
}
