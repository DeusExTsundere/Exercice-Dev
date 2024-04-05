using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string menu;

    public void ButtonOnClick()
    {
        SceneManager.LoadScene(menu, LoadSceneMode.Single);
    }
}
