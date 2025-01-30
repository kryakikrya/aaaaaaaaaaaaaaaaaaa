using UnityEngine;

public class LovePower : MonoBehaviour
{
    public double _lovePower;
    public double LPPC; //love power per click

    private void Start()
    {
        LPPC = 50;
    }
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
