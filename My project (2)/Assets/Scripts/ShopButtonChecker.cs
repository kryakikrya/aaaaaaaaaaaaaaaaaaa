using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtonChecker : MonoBehaviour
{
    [SerializeField] GameObject Button1;
    [SerializeField] BuyNewIslandScript Price1;
    [SerializeField] GameObject Button2;
    [SerializeField] BuyNewIslandScript Price2;
    [SerializeField] GameObject Button3;
    [SerializeField] BuyNewIslandScript Price3;
    [SerializeField] LifeEnergy energy;

    private void Start()
    {
        StartCoroutine(CheckButtons());
    }

    private IEnumerator CheckButtons()
    {
        Check();
        while (true) // вот за этот цикл мне по голове бы настучать, но как хорошо, что в этот код никто не смотрит
        {
            yield return new WaitForSeconds(1);
            Check();
        }
    }
    private void Check()
    {
        if (Button1 != null){
            if (energy.GetLifeEnergy() < Price1._price)
            {
                Button1.SetActive(false);
            }
            else
            {
                Button1.SetActive(true);
            }
        }
        if (Button2 != null)
        {
            if (energy.GetLifeEnergy() < Price2._price)
            {
                Button2.SetActive(false);
            }
            else
            {
                Button2.SetActive(true);
            }
        }
        if(Button3 != null)
        {
            if (energy.GetLifeEnergy() < Price3._price)
            {
                Button3.SetActive(false);
            }
            else
            {
                Button3.SetActive(true);
            }
        }
    }
}

