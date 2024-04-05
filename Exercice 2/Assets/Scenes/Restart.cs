using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private string restart;

    public void ButtonOnClick()
    {
        SceneManager.LoadScene(restart, LoadSceneMode.Single);
    }
}
