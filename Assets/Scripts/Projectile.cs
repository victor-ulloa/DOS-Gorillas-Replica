using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeReference] public float initialVelocity;
    [SerializeReference] public float angle;

    [SerializeReference] float lifetime;
    float initialVelocityX = 0;
    float initialVelocityY = 0;
    float elapsedTime = 0;
    const float gravity = -9.8f;
    Vector3 startLocation;


    // Start is called before the first frame update
    void Start()
    {
        if (lifetime <= 0)
        {
            lifetime = 2.0f;
        }

        startLocation = transform.position;

        // Calculate Initial Velocity
        initialVelocityX = initialVelocity * Mathf.Cos(angle * Mathf.PI / 180);
        initialVelocityY = initialVelocity * Mathf.Sin(angle * Mathf.PI / 180);

        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // Update Time
        elapsedTime += Time.deltaTime;

        // Update Location
        transform.position = new Vector3(
            startLocation.x + (initialVelocityX * elapsedTime),
            startLocation.y + (initialVelocityY * elapsedTime) + (0.5f * gravity * Mathf.Pow(elapsedTime, 2))
            );
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
