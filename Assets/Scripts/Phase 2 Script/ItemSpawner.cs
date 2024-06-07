using UnityEngine;
using System.Collections.Generic;

public class ItemSpawner : MonoBehaviour
{
    public List<GameObject> cubes = new List<GameObject>();

    void Start()
    {
        SpawnRandomCube();
    }

    public void SpawnRandomCube()
    {
        if (cubes.Count == 0)
        {
            Debug.LogWarning("No cubes to spawn!");
            return;
        }

        // Deactivate all cubes
        foreach (GameObject cube in cubes)
        {
            cube.SetActive(false);
        }

        // Select a random cube to activate
        GameObject cubeToSpawn = cubes[Random.Range(0, cubes.Count)];
        cubeToSpawn.SetActive(true);
    }
}