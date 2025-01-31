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
    private double _evolutionUp;
    private void Start()
    {
        _evolutionUp = 1;
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
    public void EvolutionUp()
    {
        _evolutionUp += 0.5;
    }
    private IEnumerator FarmLifeEnergy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            energy.IncreaseLifeEnergy(LEPS * _evolutionUp);
        }
    }
}
