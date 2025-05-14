using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public ProjectilePool[] pools;
    private int currentType = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Bot�n derecho cambia tipo
            currentType = (currentType + 1) % 3;

        if (Input.GetMouseButtonDown(0))
        { // Bot�n izquierdo dispara
            GameObject proj = pools[currentType].GetProjectile();
            proj.transform.position = transform.position;
            proj.SetActive(true);
        }
    }
}
