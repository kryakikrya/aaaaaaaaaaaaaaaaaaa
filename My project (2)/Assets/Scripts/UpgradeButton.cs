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
        _island.LevelUp(buff);
        _price *= _coef;
    }
}
