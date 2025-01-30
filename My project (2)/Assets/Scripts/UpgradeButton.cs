using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] LifeEnergy energy;
    [SerializeField] PlatformManager _island;
    [SerializeField] double buff;
    public double _price;
    public double _coef;

    public void LevelUp()
    {
        if (energy.GetLifeEnergy() >= _price)
        {
            _island.LevelUp(buff);
            energy.DecreaseLifeEnergy(_price);
            _price *= _coef;
        }
    }
}
