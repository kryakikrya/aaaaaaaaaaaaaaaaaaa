using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] LifeEnergy energy; // висит на UI
    //[SerializeField] Animator animator;
    private int CurrentLevel;
    private int LEPS; //life energy per second
    private void Start()
    {
        if (CurrentLevel < 2)
        {
            CurrentLevel = 1;
            LEPS = 1;
        }
        StartCoroutine(FarmLifeEnergy());
    }
    //public void ActivatePlatform()
    //{
    //    animator.SetBool("isActive", true);
    //}
    public void LevelUp()
    {
        CurrentLevel += 1;
        LEPS = CurrentLevel;
    }
    private IEnumerator FarmLifeEnergy()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            energy.IncreaseLifeEnergy(LEPS);
        }
    }
}
