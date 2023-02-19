using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform Donut;
    [SerializeField] private Transform RottenDonut;
    [SerializeField] private float SpawnTime = 1.5f;

    private float xPos;
    private float timer;
    private int ScoreTimer;
    private bool spawn;

    private void Update()
    {
        ScoreTimer = ScoreCounter.ScoreValue;
        timer += Time.deltaTime;

        xPos = UnityEngine.Random.Range(-3.5f, 3.5f);
        if(ScoreTimer == 50)
        {
            SpawnTime = 1.2f;
        }
        else if(ScoreTimer == 100)
        {
            SpawnTime = 1f;
        }
        else if(ScoreTimer == 300)
        {
            SpawnTime = 0.7f;
        }
        else if(ScoreTimer == 500)
        {
            SpawnTime = 0.6f;
        }
        else if(ScoreTimer == 1500)
        {
            SpawnTime = 0.5f;
        }
        else if(ScoreTimer == 5000)
        {
            SpawnTime = 0.3f;
        }
        if (timer >= SpawnTime)
        {
            RandomDonut();

            CreateItem();

            timer = 0;
        }
    }
    private void CreateItem()
    {

        if (spawn == true)
        {
            Instantiate(Donut, new Vector2(xPos, transform.position.y), Quaternion.identity);
            Debug.Log(spawn);
        }
        else
        {
            Instantiate(RottenDonut, new Vector2(xPos, transform.position.y), Quaternion.identity);
        }
    }
    private void RandomDonut()
    {
        int donutcount = Random.Range(0, 5);
        Debug.Log(donutcount);

        if (donutcount == 0)
        {
            spawn = false;
        }
        else
        {
            spawn = true;
        }
    }
}
