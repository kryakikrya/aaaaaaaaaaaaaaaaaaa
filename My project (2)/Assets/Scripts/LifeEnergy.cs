using System.Numerics;
using UnityEngine;

public class LifeEnergy : MonoBehaviour
{
    private int _lifeEnergy;

    public int GetLifeEnergy()
    {
        return _lifeEnergy;
    }
    public void IncreaseLifeEnergy(int plus)
    {
        _lifeEnergy += plus;
    }
}
