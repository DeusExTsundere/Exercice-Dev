using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleSol : MonoBehaviour
{
    [SerializeField] private GameObject spawn = null;
    [SerializeField] private GameObject trap1 = null;
    [SerializeField] private GameObject trap2 = null;
    [SerializeField] private GameObject trap3 = null;
    [SerializeField] private int tempsSpawn=5;
    [SerializeField] private Transform lieuSpawn = null;
    private GameObject trap = null;
    private float z_position = -0.5f;
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
            nbSpawn=Random.Range(1,4);
            Spawn();
        }
    }

    private void Spawn()
    {
        if (nbSpawn == 1)
        {
            Instantiate(trap1 , lieuSpawn.transform);
        }

        else if (nbSpawn == 2)
        {
            Instantiate(trap1,lieuSpawn.transform);
            Instantiate(trap2, lieuSpawn.transform);
        }
        else
        {
            Instantiate(trap1, lieuSpawn.transform);
            Instantiate(trap2, lieuSpawn.transform);
            Instantiate(trap3, lieuSpawn.transform);
        }

        timer = Random.Range(0,5);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(spawn);
    }
}
