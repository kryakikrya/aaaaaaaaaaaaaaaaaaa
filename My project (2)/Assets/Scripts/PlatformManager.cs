using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] LifeEnergy energy; // висит на UI
    [SerializeField] double _basicLeps;
    //[SerializeField] Animator animator;
    private int CurrentLevel;
    private double LEPS; //life energy per second
    private void Start()
    {
        if (CurrentLevel < 2)
        {
            CurrentLevel = 1;
            LEPS = _basicLeps;
        }
        StartCoroutine(FarmLifeEnergy());
    }
    //public void ActivatePlatform()
    //{
    //    animator.SetBool("isActive", true);
    //}
    public void LevelUp(double buff)
    {
        CurrentLevel += 1;
        LEPS *= buff;
    }
    private IEnumerator FarmLifeEnergy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            energy.IncreaseLifeEnergy(LEPS);
        }
    }
}
