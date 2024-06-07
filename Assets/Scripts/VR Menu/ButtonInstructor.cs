using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonInstructor : MonoBehaviour
{
    public FadeScreen fadeScreen;

    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => GoToScene(1)); // Corrected the lambda expression syntax
    }

    public void GoToScene(int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        SceneManager.LoadScene(sceneIndex);
    }
}