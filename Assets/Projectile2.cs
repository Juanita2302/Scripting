using UnityEngine;
using System.Collections;

public class Projectile2 : MonoBehaviour
{
    public ProjectilePool pool;
    public Collider targetCollider;
    public ProjectileShooter shooter;

    void OnTriggerEnter(Collider col)
    {
        StartCoroutine(DisableTemporarily(col));
        pool.ReturnProjectile(gameObject);
    }

    IEnumerator DisableTemporarily(Collider col)
    {
        col.enabled = false;
        shooter.enabled = false;
        yield return new WaitForSeconds(1);
        col.enabled = true;
        shooter.enabled = true;
    }
}
