using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject Wolfs;
    [SerializeField] private GameObject Rabbits;
    [SerializeField] private GameObject Deers;
    [SerializeField] private GameObject Player;

    [SerializeField] private Vector2 spawnPosition;

    [SerializeField] private bool random;
    [SerializeField] private int WolfCount;
    [SerializeField] private int RabbitCount;
    [SerializeField] private int DeerCount;
    private int playercount=12;
    public void OnSpawnAPrefab()
    {
        for (int i = 0; i < WolfCount; i++)
        {
            float x = Random.Range(-20, 20);
            float y = Random.Range(-11, 11);
            Instantiate(Wolfs, new Vector2(x, y), Quaternion.identity);
        }
        for (int i = 0; i < RabbitCount; i++)
        {
            float x = Random.Range(-20, 20);
            float y = Random.Range(-11, 11);
            Instantiate(Rabbits, new Vector2(x, y), Quaternion.identity);
        }
        for (int i = 0; i < DeerCount; i++)
        {
            float x = Random.Range(-2, 2);
            float y = Random.Range(-2, 2);
            Instantiate(Deers, new Vector2(x, y), Quaternion.identity);
        }
        if (playercount == 1)
        {
            Instantiate(Player, new Vector2(Random.Range(-20, 20), Random.Range(-11, 11)), Quaternion.identity);
            playercount++;
        }
        WolfCount = 0;
        RabbitCount = 0;
        DeerCount = 0;
    }

    void Update()
    {
        OnSpawnAPrefab();
    }
}
