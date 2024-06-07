using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultDisplay : MonoBehaviour
{
    public TextMeshProUGUI highlightedText;
    public TextMeshProUGUI missedText;

    void Start()
    {
        DisplayResults();
    }

    void DisplayResults()
    {
        // Retrieve the number of highlighted objects
        int highlightedCount = PlayerPrefs.GetInt("HighlightedObjectsCount", 0);
        string highlightedObjects = "Highlighted Objects:\n";
        for (int i = 0; i < highlightedCount; i++)
        {
            highlightedObjects += PlayerPrefs.GetString("HighlightedObject" + i, "Unknown") + "\n";
        }
        highlightedText.text = highlightedObjects;

        // Retrieve the number of missed objects
        int missedCount = PlayerPrefs.GetInt("MissedObjectsCount", 0);
        string missedObjects = "Missed Objects:\n";
        for (int i = 0; i < missedCount; i++)
        {
            missedObjects += PlayerPrefs.GetString("MissedObject" + i, "Unknown") + "\n";
        }
        missedText.text = missedObjects;
    }
}