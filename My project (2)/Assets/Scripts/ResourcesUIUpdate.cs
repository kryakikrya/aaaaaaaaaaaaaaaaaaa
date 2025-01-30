using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ResourcesUIUpdate : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _lifeEnergyText;
    [SerializeField] LifeEnergy energy;

    private void Start()
    {
        StartCoroutine(UpdateUI());
    }
    private IEnumerator UpdateUI()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            _lifeEnergyText.text = Mathf.Round((float)energy.GetLifeEnergy()) + "";
        }
    }
}
