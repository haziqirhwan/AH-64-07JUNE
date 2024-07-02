using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDetector : MonoBehaviour
{
    public GameObject playerTransform;
    public List<GameObject> objectToDetect = new List<GameObject>();
    public List<float> timeInView = new List<float>();

    public float detectionAngle = 45f;
    public float maxDetectionDistance = 1f;

    private bool isObjectInView = false;
    public float highlightTime = 3f;

    private HashSet<GameObject> highlightedObjects = new HashSet<GameObject>();

    private bool timerEnded = false;

    private void Start()
    {
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(120.0f);
        timerEnded = true;
        CaptureUnhighlightedObjects();
        LoadNextScene();
    }

    void Update()
    {
        for (int i = 0; i < objectToDetect.Count; i++)
        {
            Vector3 directionToTarget = objectToDetect[i].transform.position - playerTransform.transform.position;
            directionToTarget.Normalize();

            Vector3 forwardDirection = playerTransform.transform.forward;
            float angleToTarget = Vector3.Angle(forwardDirection, directionToTarget);
            float distanceToTarget = Vector3.Distance(objectToDetect[i].transform.position, playerTransform.transform.position);

            if (angleToTarget < detectionAngle && distanceToTarget <= maxDetectionDistance)
            {
                isObjectInView = true;
                timeInView[i] += Time.deltaTime;

                if (timeInView[i] >= highlightTime)
                {
                    if (!highlightedObjects.Contains(objectToDetect[i]))
                    {
                        objectToDetect[i].GetComponent<Renderer>().material.color = Color.yellow;
                        highlightedObjects.Add(objectToDetect[i]);
                        HighlightObject(objectToDetect[i]);
                    }
                }
            }
            else
            {
                isObjectInView = false;
                timeInView[i] = 0f;
            }
        }
    }

    void HighlightObject(GameObject highlightedObject)
    {
        Debug.Log("Object highlighted: " + highlightedObject.name);
        // Add any additional code here for when the object is highlighted
    }

    void CaptureUnhighlightedObjects()
    {
        if (timerEnded)
        {
            List<GameObject> missedObjects = new List<GameObject>();
            foreach (var obj in objectToDetect)
            {
                if (!highlightedObjects.Contains(obj))
                {
                    missedObjects.Add(obj);
                }
            }
            // Pass missedObjects and highlightedObjects to the next scene
            PlayerPrefs.SetInt("MissedObjectsCount", missedObjects.Count);
            for (int i = 0; i < missedObjects.Count; i++)
            {
                PlayerPrefs.SetString("MissedObject" + i, missedObjects[i].name);
            }
            PlayerPrefs.SetInt("HighlightedObjectsCount", highlightedObjects.Count);
            int j = 0;
            foreach (var obj in highlightedObjects)
            {
                PlayerPrefs.SetString("HighlightedObject" + j, obj.name);
                j++;
            }
        }
    }
    void LoadNextScene()
    {
        //SceneManager.LoadScene("Summary");
    }
}