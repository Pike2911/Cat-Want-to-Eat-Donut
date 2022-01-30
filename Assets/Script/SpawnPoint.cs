using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform Donut;
    private Vector2 randomPosition;

    private float xPos;
    private float timer;
    private int randomspawn;

    private void Update()
    {
        timer += Time.deltaTime;

        xPos = UnityEngine.Random.Range(-2.3f, 2.8f);

        if (timer >= 2)
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
