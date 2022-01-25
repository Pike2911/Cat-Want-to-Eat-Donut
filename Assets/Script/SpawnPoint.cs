using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private float spawnSpeed = 5;

    public Transform Donut;
    private Vector2 randomPosition;

    private float xPos;
    private float timer;

    private void Start()
    {
        int Count = 0;

        while(Count <= 0 || Count <= 5)
        {
            xPos = UnityEngine.Random.Range(-2.3f, 2.8f);

            CreateItem();

            Count += 1;
        }

            
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
    private void CreateItem()
    {
        Instantiate(Donut, new Vector2(xPos, transform.position.y), Quaternion.identity); 
    }
}
