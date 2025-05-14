using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectilePool : MonoBehaviour
{
    public GameObject prefab;
    protected Queue<GameObject> pool = new Queue<GameObject>();

    public GameObject GetProjectile()
    {
        if (pool.Count > 0) return pool.Dequeue();
        return Instantiate(prefab);
    }

    public void ReturnProjectile(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
