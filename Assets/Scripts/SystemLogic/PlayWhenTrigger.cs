using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWhenTrigger : MonoBehaviour
{
    public GameObject Trigger;
    public AudioSource VoiceTutorials;

    public void OnTriggerEnter(Collider other)
    {
        GameManager._me.InsideTrigger = true;
        // Check if the object entering the trigger is the player or another relevant object
        if (other.CompareTag("Player") && GameManager._me.TutorialVoiceTrigger == false && GameManager._me.IsTutorialMode == true)
        {
            StartCoroutine(PlayAudioWithDelay());
        }
        else
            return;
    }

    public void OnTriggerExit(Collider other)
    {
        GameManager._me.InsideTrigger = false;
    }

    private IEnumerator PlayAudioWithDelay()
    {
        GameManager._me.TutorialVoiceTrigger = true;
        VoiceTutorials.Play();
        Debug.Log("Voice: Tutorial Playing");

        yield return new WaitForSeconds(VoiceTutorials.clip.length);

        Trigger.SetActive(false);
        GameManager._me.TutorialVoiceTrigger = false;
    }
}