using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonMenager : MonoBehaviour
{
    [SerializeField] private GameObject[] questions;
    [SerializeField] private GameObject[] _questionsText;
    private int questionsNumber = 0;


    public void ClickingOnTheCorrectAnswer()
    {
        questions[questionsNumber].SetActive(false);
        _questionsText[questionsNumber].SetActive(false);
        questionsNumber++;
        
        if (questionsNumber == questions.Length)
        {
            SceneManager.LoadScene("winscreen");
            return;
        }
        questions[questionsNumber].SetActive(true);
        _questionsText[questionsNumber].SetActive(true);
    }
    
    public void ClickingOnTheNoCorrectAnswer()
    {
        SceneManager.LoadScene("losescreen");
    }

}
