using UnityEngine;

public class UnitSelect : MonoBehaviour
{
    private GameObject[] character;
    private int selectedCharacter;
    private const string SAVE_RPEF = "selectedCharacter";

    private void Awake() => SelectCharacterEventSystem.generatorEvents.AddListener(GenerateRandomCharacter);
    private void Start() => GeneratorCharaterMass();// заполняем масив дочерними обьектами, выключаем их оставляя первый обьект включенным.
    private void GeneratorCharaterMass()
    {
        character = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            character[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject go in character)
            go.SetActive(false);
    }
    public void GenerateRandomCharacter()
    {
        character[selectedCharacter].SetActive(false);
        GenerateCharacter generate = new GenerateCharacter(character.Length);
        selectedCharacter = generate.numberCharacter;
        character[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt(SAVE_RPEF, selectedCharacter);
    }
  

}
