using UnityEngine;

public class LoveIconScript : MonoBehaviour
{
    LovePower lovePower;

    private void Start()
    {
        lovePower = FindAnyObjectByType<LovePower>();
    }
    public void FarmLovePower()
    {
        lovePower.IncreaseLovePower(lovePower.LPPC);
        Destroy(gameObject);
    }
}
