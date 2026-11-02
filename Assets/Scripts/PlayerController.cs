using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileVelocity;
    [SerializeField] private InputActionReference fire;

    void Update()
    {
        if (fire.action.WasPressedThisFrame())
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
            projectile.GetComponent<Projectile>().SetVelocity(projectileVelocity);
        }
    }
}
