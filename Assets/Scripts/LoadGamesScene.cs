using UnityEngine;

public class LoadGamesScene : UnitSelect
{
    [SerializeField] private GameObject[] parentCharacter;
    private int selectedCharaterGamesScene;
    private const string SAVE_RPEF = "selectedCharacter";
    void Start() => StartScene();
    private void StartScene()
    {
        LoadSelectedCharacter();

        for (int i = 0; i < transform.childCount; i++)
        {
            parentCharacter[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject go in parentCharacter)
        {
            go.SetActive(false);
        }

        parentCharacter[selectedCharaterGamesScene].SetActive(true);
    }
    private void LoadSelectedCharacter() => selectedCharaterGamesScene = PlayerPrefs.GetInt(SAVE_RPEF);
}
