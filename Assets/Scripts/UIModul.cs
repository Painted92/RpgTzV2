using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIModul : UnitSelect
{
    private void Awake()
    {
        EventSystemTZ.generatorEvents.AddListener(GenerateRandomCharacter);
        EventSystemTZ.playEvents.AddListener(PlayGameScene);
        EventSystemTZ.backEvents.AddListener(BackMenu);
    }
    public void GenerateCharacter()
    {
        EventSystemTZ.SendGeneratCharacter();
    }
    public void PlayMode()
    {
        EventSystemTZ.PlayCharacter();
    }
    public void BackMainMenu()
    {
        EventSystemTZ.BackMenu();
    }

    private static void BackMenu() => SceneManager.LoadScene(0);
    private static void PlayGameScene() => SceneManager.LoadScene(1);
}

