using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ButtonExercice2 : MonoBehaviour
{

    [SerializeField] private string exercice2;
  
    public void ButtonExercieOnClick()
    {
        SceneManager.LoadScene(exercice2,LoadSceneMode.Single);
    }
}
