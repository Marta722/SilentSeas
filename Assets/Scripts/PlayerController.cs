using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileVelocity;
    [SerializeField] private InputActionReference fireRight;
    [SerializeField] private InputActionReference fireLeft;

    void Update()
    {
        if (fireRight.action.WasPressedThisFrame())
        {
            Fire(-90);
        }

        if (fireLeft.action.WasPressedThisFrame())
        {
            Fire(90);
        }
    }

    void Fire(float angle)
    {
        Quaternion rotation = transform.rotation * Quaternion.Euler(0, 0, angle);
        GameObject projectile = Instantiate(projectilePrefab, transform.position, rotation);
        projectile.GetComponent<Rigidbody2D>().linearVelocity = projectile.transform.up * projectileVelocity;
    }
}
