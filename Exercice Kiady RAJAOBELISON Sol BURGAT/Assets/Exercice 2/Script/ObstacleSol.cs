using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleSol : MonoBehaviour
{
    [SerializeField] private GameObject trap1 = null;
    [SerializeField] private float tempsSpawn=3.5f;
    [SerializeField] private Transform lieuSpawn;
    private float timer = 0;

    private void Start()
    {
        Transform lieuSpawn = GetComponent<Transform>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= tempsSpawn)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(trap1 , lieuSpawn.transform);
        timer = Random.Range(0,5);
    }
}
