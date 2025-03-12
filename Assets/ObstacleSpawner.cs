using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Assign your obstacle prefab in the Inspector
    public float spawnInterval = 1.5f;
    public float minX = -3f; // Adjust based on your road width
    public float maxX = 3f;
    public float spawnY = 5f; // Adjust based on where obstacles should appear

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(minX, maxX);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
