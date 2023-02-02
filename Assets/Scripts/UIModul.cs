using UnityEngine;
using UnityEngine.SceneManagement;

public class UIModul : MonoBehaviour
{
    public void GenerateCharacter()
    {
        SelectCharacterEventSystem.SendGeneratCharacter();
    }
    public void PlayMode()
    {
        SceneManager.LoadScene(1);
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

