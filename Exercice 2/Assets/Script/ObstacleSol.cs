using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSol : MonoBehaviour
{
    [SerializeField] private GameObject trap1 = null;
    [SerializeField] private GameObject trap2 = null;
    [SerializeField] private GameObject trap3 = null;
    [SerializeField] private GameObject lieuSpawn = null;
    [SerializeField] private int tempsSpawn=10;
    private float z_position = -0.5f;
    //private float x_position = lieuSpawn.transform.position.x;

    private GameObject trap = null;
    private float timer = 0;
    private int nbSpawn = 0;

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
            trap = Instantiate(trap1);
            trap.transform.position = lieuSpawn.transform.position;
            trap = null;
        }

        else if (nbSpawn == 2)
        {
            trap = Instantiate(trap1);
            trap.transform.position = lieuSpawn.transform.position;
            trap = null;
            trap = Instantiate(trap2);
            //trap.transform.position = transform.position + new Vector3(x_position,z_position,-1);
        }
        else
        {

        }

        timer = 0;
    }
}
