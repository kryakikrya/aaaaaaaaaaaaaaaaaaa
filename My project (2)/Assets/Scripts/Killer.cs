using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Killer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(KillMe());
    }

    private IEnumerator KillMe()
    {
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }
}
