using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button LVL1,LVL2,LVL3;
 public enum ButtonType{
    LVL1,
    LVL2,
    LVL3
  }
    void Start()
    {
      LVL1.onClick.AddListener(()=> LEVELS(ButtonType.LVL1));
      LVL2.onClick.AddListener(()=> LEVELS(ButtonType.LVL2));
      LVL3.onClick.AddListener(()=> LEVELS(ButtonType.LVL3));
    }
public void LEVELS(ButtonType buttonType)
{
     switch (buttonType)
    {
        case ButtonType.LVL1:
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            break;
        case ButtonType.LVL2:
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
            break;
        case ButtonType.LVL3:
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
            break;
        default:
            Debug.LogError("Кнопка не назначенна");
            break;
    }
}

}

