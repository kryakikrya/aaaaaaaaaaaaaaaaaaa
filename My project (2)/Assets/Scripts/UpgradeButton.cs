using TMPro;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] LifeEnergy energy;
    [SerializeField] LovePower power;
    [SerializeField] PlatformManager _island;
    [SerializeField] double buff;
    [SerializeField] TextMeshProUGUI _priceText;
    public double _price;
    public double _coef;

    private void Start()
    {
        _priceText.text = Mathf.Round((float)_price) + "";
    }
    public void LevelUp()
    {
        if (energy.GetLifeEnergy() >= _price)
        {
            _island.LevelUp(buff);
            energy.DecreaseLifeEnergy(_price);
            _price *= _coef;
            _priceText.text = Mathf.Round((float)_price) + "";
        }
    }
    public void EvolutionUp()
    {
        if (energy.GetLifeEnergy() >= _price)
        {
            _island.EvolutionUp();
            power.DecreaseLovePower(_price);
            _price *= _coef;
            _priceText.text = Mathf.Round((float)_price) + "";
        }
    }
}
