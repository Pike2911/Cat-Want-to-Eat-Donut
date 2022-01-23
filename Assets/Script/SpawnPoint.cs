using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform prefab;

    private void Start()
    {
        Instantiate(prefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }   
}
