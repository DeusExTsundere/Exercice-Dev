using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonExercice3 : MonoBehaviour
{
    [SerializeField] private string exercice3;

    public void ButtonExercieOnClick()
    {
        SceneManager.LoadScene(exercice3, LoadSceneMode.Single);
    }
}
