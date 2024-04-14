using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMeteor : MonoBehaviour
{
    [SerializeField] private GameObject meteorPrefab;
    [SerializeField] private GameObject spawnLimiteDroite;
    [SerializeField] private GameObject spawnLimiteGauche;
    private float x;
    private Vector3 spawnGauche;
    private Vector3 spawnDroite;
    private float randomSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        spawnDroite = spawnLimiteDroite.transform.position;
        spawnGauche = spawnLimiteGauche.transform.position;
        randomSpawnTime = Random.Range(0.5f,10.0f);
    }

    // Update is called once per frame
    void Update()
    { 
        if (randomSpawnTime <= 0)
        {
            randomSpawnTime = Random.Range((0.5f+Time.deltaTime*10), (3.5f + Time.deltaTime * 10));
            x = Random.Range((spawnGauche.x),(spawnDroite.x));
            Instantiate(meteorPrefab,new Vector3(x,transform.position.y,transform.position.x),Quaternion.identity);
        }

        else
        {
            randomSpawnTime -=Time.deltaTime;
        }
        
    }
}
