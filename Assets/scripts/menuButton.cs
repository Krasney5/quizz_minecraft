using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuButton : MonoBehaviour
{
    [SerializeField] private GameObject[] _menuButton;
    [SerializeField] private GameObject[] _lvlButton;
    

    public void PlayButton()
    {
        for (int i = 0; i < _menuButton.Length; i++)
        {
            _menuButton[i].SetActive(false);
        }

        for (int i = 0; i < _lvlButton.Length; i++)
        {
            _lvlButton[i].SetActive(true);
        }
    }

    public void EzLvlLoad()
    {
        SceneManager.LoadScene("EzLvl");
    }
    
    
    public void MidLvlLoad()
    {
        SceneManager.LoadScene("MidLvl");
    }
    
    
    public void HardLvlLoad()
    {
        SceneManager.LoadScene("HardLvl");
    }
}
