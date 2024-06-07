using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Playables;
using TMPro;

public class TimerTest : MonoBehaviour
{
    public float timeLimit = 10f;
    private float timeRemaining;
    public TextMeshProUGUI timerText;
    public ObjectRandomizer objectRandomizer; // Reference to the ObjectRandomizer script
    private int objectsFound = 0;

    void Start()
    {
        timeRemaining = timeLimit;
        GameData.objectsFound = 0; // Initialize the data

        // Initialize GameData based on the randomizer
        GameData.totalObjects = objectRandomizer.targetObjects.Count;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            EndTimerTest();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; // To display full seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void ObjectFound()
    {
        objectsFound++;
        GameData.objectsFound = objectsFound;
    }

    void EndTimerTest()
    {
        // Store data in GameData
        GameData.objectsNotFound = GameData.totalObjects - objectsFound;
        // Transition to summary screen
        SceneManager.LoadScene("Summary");
    }
}