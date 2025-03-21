using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class CharactersManager : MonoBehaviour
{
    public List<GameObject> CurrentCharactersList = new List<GameObject>();
    [SerializeField] LovePower lovePower;
    [SerializeField] GameObject loveMassage;
    [SerializeField] GameObject loveBubble;
    private void Start()
    {
        StartCoroutine(ReloadText());
        StartCoroutine(ReloadBubble());
    }
    private IEnumerator ReloadBubble()
    {
        while (true)
        {
            yield return new WaitForSeconds(30);
            CreateLoveBubble();
        }
    }
    private IEnumerator ReloadText()
    {
        while (true)
        {
            yield return new WaitForSeconds(30);
            CreateText();
        }
    }
    public void CreateText()
    {
        if (CurrentCharactersList.Count > 0)
        {
            Instantiate(loveMassage, CurrentCharactersList[Random.Range(0, CurrentCharactersList.Count)].transform);
        }
    }
    public void CreateLoveBubble()
    {
        if (CurrentCharactersList.Count > 0)
        {
            Instantiate(loveBubble, CurrentCharactersList[Random.Range(0, CurrentCharactersList.Count)].transform);
        }
    }
    p
}
