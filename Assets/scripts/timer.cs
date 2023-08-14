using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] private float timers;
    [SerializeField] private TextMeshProUGUI timerText;

    private void Update()
    {
        timers -= Time.deltaTime;
        timerText.text = Mathf.Round(timers).ToString();

        if (timers <= 0)
        {
            SceneManager.LoadScene("losescreen");
        }
    }
}
