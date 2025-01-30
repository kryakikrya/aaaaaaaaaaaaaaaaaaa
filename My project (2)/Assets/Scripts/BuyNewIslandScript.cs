using Unity.VisualScripting;
using UnityEngine;

public class BuyNewIslandScript : MonoBehaviour
{
    [SerializeField] LifeEnergy energy;
    [SerializeField] GameObject _islandPrefab;
    public double _price;
    
    public void BuyNewIsland()
    {
        if (energy.GetLifeEnergy() >= _price)
        {
            energy.DecreaseLifeEnergy(_price);
            _islandPrefab.SetActive(true);
        }
    }
    
}
