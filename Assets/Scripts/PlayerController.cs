using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeReference] Transform spawnPoint;
    [SerializeReference] Projectile projectilePrefab;

    public void Shoot(float initialVelocity, float angle)
    {
        projectilePrefab.initialVelocity = initialVelocity;
        projectilePrefab.angle = angle;
        Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
