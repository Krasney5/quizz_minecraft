using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenager : MonoBehaviour
{
    [SerializeField] private GameObject[] questions;

    private int questionsNumber = 0;


    public void ClickingOnTheCorrectAnswer()
    {
        questions[questionsNumber].SetActive(false);
        questionsNumber++;
        questions[questionsNumber].SetActive(true);
    }

}
