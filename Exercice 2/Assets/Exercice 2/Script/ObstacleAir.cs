using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleAir : MonoBehaviour
{
    [SerializeField] private GameObject trap1 = null;
    [SerializeField] private GameObject trap2 = null;
    [SerializeField] private int tempsSpawn = 10;
    [SerializeField] private Transform lieuSpawn = null;
    private float timer = 0;
    private int nbSpawn = 0;

    private void Start()
    {
        Transform lieuSpawn = GetComponent<Transform>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= tempsSpawn)
        {
            nbSpawn = Random.Range(1, 3);
            Spawn();
        }
    }

    private void Spawn()
    {
        if (nbSpawn == 1)
        {
            Instantiate(trap1, lieuSpawn.transform);
        }

        else
        {
            Instantiate(trap1, lieuSpawn.transform);
            Instantiate(trap2, lieuSpawn.transform);
        }

        timer = Random.Range(0, 5);
    }
}
