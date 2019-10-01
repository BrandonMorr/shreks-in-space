using UnityEngine;

public class ShrekSpawner : MonoBehaviour
{
    public GameObject ShrekPrefab;
    // Size property controls the dimensions of the spawner.
    public Vector3 size;
    // Number of Shreks to spawn in the zone.
    public int numberOfShreks = 10;
    public bool enableSpawner = true;

    // Awake is called when the script instance is being loaded. 
    void Awake()
    {
        if (enableSpawner)
        {
            for (int i = 0; i <= numberOfShreks; i++)
            {
                SpawnShrek();
            }
        }
    }

    // Spawn the damn ogres.
    public void SpawnShrek()
    {
        Vector3 worldPos = transform.position;
        Vector3 shrekPos = worldPos + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        
        Quaternion rot = Quaternion.Euler(new Vector3(Random.Range(1f, 360f), Random.Range(1f, 360f), Random.Range(1f, 360f)));

        Instantiate(ShrekPrefab, shrekPos, rot, gameObject.transform);
    }

    // Show the spawn zone in the scene editor.
    private void OnDrawGizmosSelected()
    {
        Vector3 worldPos = transform.position;
        Gizmos.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), 0.5f);
        Gizmos.DrawCube(worldPos, size);
    }
}
