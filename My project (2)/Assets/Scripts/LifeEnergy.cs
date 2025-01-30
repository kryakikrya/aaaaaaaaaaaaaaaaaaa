using System.Numerics;
using UnityEngine;

public class LifeEnergy : MonoBehaviour
{
    private double _lifeEnergy;

    public double GetLifeEnergy()
    {
        return _lifeEnergy;
    }
    public void IncreaseLifeEnergy(double plus)
    {
        _lifeEnergy += plus;
    }
    public void DecreaseLifeEnergy(double minus)
    {
        _lifeEnergy -= minus;
    }
}
