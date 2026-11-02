using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float lifetime;
    float _velocity;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
    void Update()
    {
        transform.position += Time.deltaTime * _velocity * Vector3.right;
    }

    public void SetVelocity(float velocity)
    {
        _velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
