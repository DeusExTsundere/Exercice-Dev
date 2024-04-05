using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonExercice1 : MonoBehaviour
{
    [SerializeField] private string exercice1;

    public void ButtonExercieOnClick()
    {
        SceneManager.LoadScene(exercice1, LoadSceneMode.Single);
    }
}
