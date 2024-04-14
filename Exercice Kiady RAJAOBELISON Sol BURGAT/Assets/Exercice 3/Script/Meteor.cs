using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float speed;
    private float scale;
    private int vie;

    private void Start()
    {
        speed = Random.Range(0.2f, 4.0f) ;
        scale = Random.Range(0.5f,2.5f) ;
        vie = Random.Range(1,7);
        gameObject.transform.localScale=(new Vector3(scale,scale,scale));
    }

    void Update()
    {
        Vector3 _currentPosition = transform.position;
        _currentPosition.y -= speed * Time.deltaTime;
        transform.position = _currentPosition;
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            vie -= 1;
            if (vie <= 0)
            {
                Destroy(gameObject) ;
            }
        }
    }
}
