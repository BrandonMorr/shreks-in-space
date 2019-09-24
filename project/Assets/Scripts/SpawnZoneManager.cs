using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZoneManager : MonoBehaviour
{
    public GameObject SpawnZoneObject;

    // Awake is called when the script instance is being loaded.
    void Awake() {
        // Create a 3x3x3 cube of ShrekSpawners.
        for (int x = -250; x <= 250; x += 250) {
            for (int y = -250; y <= 250; y += 250) {
                for (int z = -250; z <= 250; z += 250) {
                    // Create a ShrekSpawner.
                    Vector3 pos = new Vector3(x, y, z);
                    Quaternion rot = new Quaternion();

                    GameObject spawner = (GameObject) Instantiate(SpawnZoneObject, pos, rot, gameObject.transform);
                }
            }
        }
    }
}
