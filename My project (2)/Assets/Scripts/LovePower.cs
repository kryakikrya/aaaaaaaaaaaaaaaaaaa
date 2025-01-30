using UnityEngine;

public class LovePower : MonoBehaviour
{
    private double _lovePower;
    public double GetLovePower()
    {
        return _lovePower;
    }
    public void IncreaseLovePower(double plus)
    {
        _lovePower += plus;
    }
    public void DecreaseLovePower(double minus)
    {
        _lovePower -= minus;
    }
}
