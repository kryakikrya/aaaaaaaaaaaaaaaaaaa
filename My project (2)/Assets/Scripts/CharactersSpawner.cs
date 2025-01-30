using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CharactersSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> CharactersList = new List<GameObject>();
    [SerializeField] List<GameObject> SpawnPointsList = new List<GameObject>();
    [SerializeField] CharactersManager charactersManager;

    public void SpawnNewCharacter()
    {
        if (CharactersList.Count > 0)
        {
            Instantiate(CharactersList[0], SpawnPointsList[0].transform);
            charactersManager.CurrentCharactersList.Add(CharactersList[0]);
            CharactersList.Remove(CharactersList[0]);
            SpawnPointsList.Remove(SpawnPointsList[0]);
        }
    }
}
