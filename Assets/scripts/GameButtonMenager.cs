using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonMenager : MonoBehaviour
{
    [SerializeField] private GameObject[] questions;

    private int questionsNumber = 0;


    public void ClickingOnTheCorrectAnswer()
    {
        questions[questionsNumber].SetActive(false);
        questionsNumber++;
        
        if (questionsNumber == questions.Length)
        {
            SceneManager.LoadScene("winscreen");
        }
        questions[questionsNumber].SetActive(true);
    }
    public void ClickingOnTheNoCorrectAnswer()
    {
        SceneManager.LoadScene("losescreen");
    }

}
