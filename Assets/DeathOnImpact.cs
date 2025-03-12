using UnityEngine;

public class DeathOnAnyImpact : MonoBehaviour
{
    public GameObject explosionPrefab; // Assign this in the Inspector

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        // Instantiate the explosion at the car's position
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }

        // Destroy the car
        Destroy(gameObject);
    }
}
