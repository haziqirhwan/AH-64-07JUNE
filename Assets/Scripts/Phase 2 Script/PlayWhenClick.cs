using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWhenClick : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayButton;
    public AudioSource VoiceTutorials;
    public GameObject Area;

    // When the programme initially start, canvas is set not to spawn.
    void Start()
    {
        PlayButton.SetActive(false);  
    }

    //Trigger to activiate
    public void OnTriggerEnter(Collider other) //find trigger to activate this
    {
        if (other.CompareTag("Player") && GameManager._me.TutorialVoiceTrigger == false && GameManager._me.IsTutorialMode == true)
        {
            PlayButton.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other) //disable when leaving the area
    {
        if (other.CompareTag("Player"))
        {
            PlayButton.SetActive(false);
        }
    }

    public void PlayButton1()
    {
        StartCoroutine(PlayAudioWithDelay());
        Debug.Log("PlayButton1 Pressed");
    }

    private IEnumerator PlayAudioWithDelay()
    {
        GameManager._me.TutorialVoiceTrigger = true;
        Debug.Log("Voice: Tutorial Playing");
        VoiceTutorials.Play();
        //Debug.Log("Voice: Tutorial Playing");

        yield return new WaitForSeconds(VoiceTutorials.clip.length);

       
        GameManager._me.TutorialVoiceTrigger = false;
    }

}
