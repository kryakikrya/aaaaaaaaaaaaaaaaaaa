using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CharactersSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> CharactersList = new List<GameObject>();
    [SerializeField] List<GameObject> SpawnPointsList = new List<GameObject>();
    [SerializeField] CharactersManager charactersManager;
    [SerializeField] LovePower power;
    [SerializeField] LifeEnergy energy;
    [SerializeField] GameObject button;
    private GameObject currentCharacter;
    public double _price;


    public void SpawnNewCharacter()
    {
        if (CharactersList.Count > 0)
        {
            if (energy.GetLifeEnergy() >= _price)
            {
                currentCharacter = Instantiate(CharactersList[0], SpawnPointsList[0].transform);
                charactersManager.CurrentCharactersList.Add(currentCharacter);
                CharactersList.Remove(CharactersList[0]);
                SpawnPointsList.Remove(SpawnPointsList[0]);
                power.LPPC += 5;
                energy.DecreaseLifeEnergy(_price);
            }
        }
        else
        {
            Destroy(button);
        }
    }
}
