using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGameMenu : MonoBehaviour
{
    public static FinalGameMenu instance;
    [SerializeField] private GameObject fundo, finishText, botaoMenu, botaoSair;
    
    void Awake()
    {
        instance = this;
    }
    public void FinishGame()
    {
        fundo.SetActive(true);
        finishText.SetActive(true);
        botaoSair.SetActive(true);
        botaoMenu.SetActive(false);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
