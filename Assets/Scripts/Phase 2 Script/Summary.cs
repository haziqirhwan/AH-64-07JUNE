using UnityEngine;
using UnityEngine.UI;

public class Summary : MonoBehaviour
{
    public Text totalText;
    public Text foundText;
    public Text notFoundText;

    void Start()
    {
        // Display the summary
        totalText.text = "Total Objects: " + GameData.totalObjects;
        foundText.text = "Objects Found: " + GameData.objectsFound;
        notFoundText.text = "Objects Not Found: " + GameData.objectsNotFound;
    }
}