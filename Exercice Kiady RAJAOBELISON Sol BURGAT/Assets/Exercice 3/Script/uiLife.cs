using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uiLife : MonoBehaviour
{
    [SerializeField] private Pointdevie character;
    private int score;
    private TextMeshProUGUI life;
    
    void Start()
    {
        life = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        life.SetText("Point de vie : " + character.vie);
    }
}
