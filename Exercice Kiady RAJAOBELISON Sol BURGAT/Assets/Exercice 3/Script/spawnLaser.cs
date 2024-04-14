using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLaser : MonoBehaviour
{
    [SerializeField] private KeyCode shoot;
    [SerializeField] private GameObject laser;
    [SerializeField] private float tempsRecharge=1.5f;
    [SerializeField] private Transform vaisseauTransform;
    private Vector3 vector3Vaisseau;
    private float charge=0;

    private void Start()
    {
        Transform vaisseauTransform=GetComponent<Transform>();
    }
    void Update()
    {
        Vector3 vector3Vaisseau = vaisseauTransform.position;
        if (Input.GetKey(shoot) && charge >= tempsRecharge)
        {
            GameObject Laser = Instantiate(laser, vector3Vaisseau, Quaternion.identity);
            charge = 0;
        }
        else
        {
            charge += Time.deltaTime * 2;
        }
    }


}
