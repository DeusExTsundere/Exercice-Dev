using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ButtonExercice2 : MonoBehaviour
{
    [SerializeField] private string exercice2;
    private Button buttonExercice2;
    private void Start()
    {
        Button buttonExercice2 = GetComponent<Button>();
        buttonExercice2.onClick.AddListener(ButtonExercieOnClick);
    }
    private void ButtonExercieOnClick()
    {
        Debug.Log("Click Ok");
        SceneManager.LoadScene(exercice2,LoadSceneMode.Single);
    }
}
