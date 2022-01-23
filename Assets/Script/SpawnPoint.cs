using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private float spawnSpeed = 5;

    public Transform Donut;
    private Vector2 randomPosition;

    private float xPos;

    private void Start()
    {
        int Count = 0;

        while(Count <= 0 || Count <= 5)
        { }

            if(Count <= 0|| Count <= 5)
            {
            CreateItem();

            Count += 1;
            }
    }
    private void Update()
    {
        xPos = UnityEngine.Random.Range(-2.3f, 2.8f);

    }
    private void CreateItem()
    {
        Instantiate(Donut, new Vector2(xPos, transform.position.y),Quaternion.identity);
    }
}
