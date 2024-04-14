using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterUpDown : MonoBehaviour
{
    private int speed;
    private characterControler characterControler;
    private KeyCode keyUp;
    private KeyCode keyDown;
    private void Awake()
    {
        characterControler = GetComponent<characterControler>();
    }

    private void Start()
    {
        speed = characterControler.vitesse;
        keyDown = characterControler.down;
        keyUp = characterControler.up;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyDown))
        {
            moveDown();
        }
        else if (Input.GetKey(keyUp))
        {
            moveUp();
        }
    }

    private void moveUp()
    {
        Vector3 _currentPosition = transform.position;
        _currentPosition.y += speed * Time.deltaTime;
        transform.position = _currentPosition;
    }

    private void moveDown()
    {
        Vector3 _currentPosition = transform.position;
        _currentPosition.y -= speed * Time.deltaTime;
        transform.position = _currentPosition;
    }
}
