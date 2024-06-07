using UnityEngine;
using System.Collections.Generic;

public class ObjectRandomizer : MonoBehaviour
{
    public List<GameObject> allObjects; // List of all possible objects
    public List<GameObject> targetObjects; // List of objects to be found

    void Start()
    {
        InitializeTargetObjects();
    }

    void InitializeTargetObjects()
    {
        // Populate allObjects with all possible objects in the scene
        allObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Defects"));

        // Randomly select a subset of objects to be the target objects
        int targetCount = Random.Range(0, allObjects.Count); // Example range, adjust as needed
        targetObjects = new List<GameObject>();

        for (int i = 0; i < targetCount; i++)
        {
            int index = Random.Range(0, allObjects.Count);
            targetObjects.Add(allObjects[index]);
            allObjects.RemoveAt(index);
        }

        // Optional: Mark the target objects (for visual indication or game logic)
        foreach (GameObject obj in targetObjects)
        {
            // Example: change the color or add an identifier
            obj.GetComponent<Renderer>().material.color = Color.red; // Example: change color
            // Or set a script variable to indicate it's a target object
        }
    }
}
