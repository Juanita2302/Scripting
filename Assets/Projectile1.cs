using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    public ProjectilePool pool;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Impacto del tipo 1");
        pool.ReturnProjectile(gameObject);
    }

}
