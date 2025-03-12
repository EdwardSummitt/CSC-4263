using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float lifetime = 5f; // Time before the object disappears

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
