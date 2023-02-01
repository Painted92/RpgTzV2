using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIModul : UnitSelect
{
    public void GenerateCharacter() => GenerateRandomCharacter();  // генерация персонажа по нажатию на кнопку.
    public void PlayMode()=> SceneManager.LoadScene(1); // запуск игры с загруженым персонажем.
    public void BackMainMenu() => SceneManager.LoadScene(0); // возврат в меню выбора персонажа

   
}
