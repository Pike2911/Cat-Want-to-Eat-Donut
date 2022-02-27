using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform Donut;
    [SerializeField] private float SpawnTime = 1.5f;

    private float xPos;
    private float timer;
    private int randomspawn;
    private int ScoreTimer;

    private void Update()
    {
        ScoreTimer = ScoreCounter.ScoreValue;
        timer += Time.deltaTime;

        xPos = UnityEngine.Random.Range(-2.66f, 3.2f);
        if(ScoreTimer == 50)
        {
            SpawnTime = 1.25f;
        }
        else if(ScoreTimer == 100)
        {
            SpawnTime = 1.1f;
        }
        else if(ScoreTimer == 300)
        {
            SpawnTime = 1;
        }
        else if(ScoreTimer == 500)
        {
            SpawnTime = 0.9f;
        }
        else if(ScoreTimer == 800)
        {
            SpawnTime = 0.8f;
        }
        else if(ScoreTimer == 1500)
        {
            SpawnTime = 0.6f;
        }
        else if(ScoreTimer == 3000)
        {
            SpawnTime = 0.5f;
        }
        else if(ScoreTimer == 5000)
        {
            SpawnTime = 0.4f;
        }
        else if(ScoreTimer == 100000)
        {
            SpawnTime = 0.15f;
        }
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
