using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnInterval = 3;
    private float time = 0;
    public float heightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnInterval)
        {
            time += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            time = 0;
        }
    }

    void SpawnPipe()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Instantiate
        (
            pipe,
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)),
            transform.rotation
        );
    }
}
