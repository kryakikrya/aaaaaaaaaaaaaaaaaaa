using Unity.VisualScripting;
using UnityEngine;

public class BuyNewIslandScript : MonoBehaviour
{
    [SerializeField] LifeEnergy energy;
    [SerializeField] GameObject _islandPrefab;
    public double _price;
    
    public void BuyNewIsland()
    {
        Debug.Log("1");
        if (energy.GetLifeEnergy() >= _price)
        {
            Debug.Log("2");
            energy.DecreaseLifeEnergy(_price);
            _islandPrefab.SetActive(true);
            Destroy(gameObject);
        }
    }
    
}
