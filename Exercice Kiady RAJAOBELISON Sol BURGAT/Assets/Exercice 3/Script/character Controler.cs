using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class characterControler : MonoBehaviour
{
    [Header("Réglage Touche")]
    [SerializeField] private KeyCode leftKey;
    [SerializeField] private KeyCode rightKey;
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;
    [Header("Réglage personnage")]
    [SerializeField] private int speed=10;
    public int vitesse { get { return speed;  } }
    public KeyCode up {  get { return upKey; } }
    public KeyCode down { get { return downKey; } }
    private float limit = 8.5f;
    private float _currentPosition;

    void Update()
    {
        float _currentPosition = transform.position.x;
        if (Input.GetKey(leftKey) && _currentPosition >= -limit) 
        {
            moveLeft();
        }

        else if (Input.GetKey(rightKey) && _currentPosition <= limit )
        {
            moveRigth();
        }
    }


    private void moveLeft()
    {
        Vector3 _currentPosition = transform.position;
        _currentPosition.x -= speed * Time.deltaTime;
        transform.position = _currentPosition;
    }

    private void moveRigth()
    {
        Vector3 _currentPosition = transform.position;
        _currentPosition.x += speed * Time.deltaTime;
        transform.position = _currentPosition;
    }
}
