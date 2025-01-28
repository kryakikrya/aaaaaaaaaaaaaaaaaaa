using UnityEngine;
using UnityEngine.UIElements;

public class PlatformManager : MonoBehaviour
{

    [SerializeField] Animator animator;
    public void ActivatePlatform()
    {
        animator.SetBool("isActive", true);
    }
}
