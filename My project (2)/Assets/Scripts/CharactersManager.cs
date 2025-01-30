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
    private void Start()
    {
        StartCoroutine(Reload());
    }
    private IEnumerator Reload()
    {
        while (true)
        {
            yield return new WaitForSeconds(30);
            CreateLoveBubble();
        }
    }
    public void CreateLoveBubble()
    {
        if (CurrentCharactersList.Count > 0)
        {
            Instantiate(loveMassage, CurrentCharactersList[Random.Range(0, CurrentCharactersList.Count)].transform);
        }
    }
}
