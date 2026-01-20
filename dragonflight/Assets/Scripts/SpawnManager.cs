using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = true;

    public GameObject enemyPrefab;
    public BoxCollider2D spawnArea;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }


    void SpawnEnemy()
    {
        Vector2 randomPos = GetRandomPoint();

        if (enableSpawn == true)
        {
            Instantiate(enemyPrefab, randomPos, Quaternion.identity);
        }

    }

    Vector2 GetRandomPoint()
    {
        Vector2 center = spawnArea.bounds.center;
        Vector2 size = spawnArea.bounds.size;

        float x = Random.Range(center.x - size.x / 2, center.x + size.x / 2);
        float y = Random.Range(center.y - size.y / 2, center.y + size.y / 2);

        return new Vector2(x, y);
    }
}
