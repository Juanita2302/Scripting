
using UnityEngine;
using System.Collections;
public class Projectile3 : MonoBehaviour
{
    public ProjectilePool pool;
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponentInChildren<ParticleSystem>();
    }

    void OnTriggerEnter(Collider col)
    {
        ps.Play();
        pool.ReturnProjectile(gameObject);
    }
}