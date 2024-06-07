using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using System.Threading.Tasks;

public class HelicopterTutorial : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayButton;
    public AudioSource VoiceTutorials;
    public GameObject Area;
    public List<MeshRenderer> DeactiviateMesh = new List<MeshRenderer>(); //a
    public List<GameObject> introCanvas = new List<GameObject>(); //i
    public List<GameObject> borderIntroduction = new List<GameObject>(); //b
    public GameObject StandHere;
    public GameObject NextArea;
    public GameObject NextAreaCanvas;
   

    // When the programme initially start, canvas is set not to spawn.
    async void Start()
    {
        PlayButton.SetActive(false);
        StandHere.SetActive(false);

        for (int i = 0; i < introCanvas.Count; i++)
        {
            introCanvas[i].SetActive(false);
        }
        for (int b = 0; b < borderIntroduction.Count; b++)
        {
            borderIntroduction[b].SetActive(false);
        }
        
        NextArea.SetActive(false);
        NextAreaCanvas.SetActive(false);

    }


    //Trigger to activiate
    public void OnTriggerEnter(Collider other) //find trigger to activate this
    {
        if (other.CompareTag("Player") && GameManager._me.TutorialVoiceTrigger == false && GameManager._me.IsTutorialMode == true)
        {
            PlayButton.SetActive(true);
            for (int i = 0; i < introCanvas.Count; i++)
            {

            introCanvas[i].SetActive(true);
            
            }
            StandHere.SetActive(true);
            StandHere.GetComponent<Renderer>().material.color = Color.yellow;
            NextAreaCanvas.SetActive(false);
        }
        
    }
    public void OnTriggerExit(Collider other) //disable when leaving the area
    {
        if (other.CompareTag("Player") && GameManager._me.TutorialVoiceTrigger == false && GameManager._me.IsTutorialMode == true)
        {
            PlayButton.SetActive(false);
            Debug.Log("hello, working");
            for (int i = 0; i < introCanvas.Count; i++)
            {
                introCanvas[i].SetActive(false);
               
            }
            StandHere.SetActive(false);
        }


    }

    public void PlayButton1()
    {
        
        Debug.Log("PlayButton1 Pressed");
        Debug.Log("mesh count: " + DeactiviateMesh.Count);
        StartCoroutine(PlayAudioWithDelay());
        for (int i = 0; i < DeactiviateMesh.Count; i++)
        {
            DeactiviateMesh[i].enabled = false;
            Debug.Log("disable mesh: " + i);
        }
        for (int a = 0; a < borderIntroduction.Count; a++)
        {
            borderIntroduction[a].SetActive(true); // tutorial border appear
        }
        Debug.Log("mesh count: " + DeactiviateMesh.Count);

        

    }

    private IEnumerator PlayAudioWithDelay()
    {
        GameManager._me.TutorialVoiceTrigger = true;
        Debug.Log("Voice: Tutorial Playing");
        VoiceTutorials.Play();
        //Debug.Log("Voice: Tutorial Playing");
        Debug.Log("delay");
        yield return new WaitForSeconds(VoiceTutorials.clip.length);
        Debug.Log("delay finish");



        GameManager._me.TutorialVoiceTrigger = false;
        for (int i = 0; i < DeactiviateMesh.Count; i++)
        {
            
            DeactiviateMesh[i].enabled = true;
        }
        for(int a = 0; a < borderIntroduction.Count; a++)
        {
            
            borderIntroduction[a].SetActive(false); // tutorial border disappear
        }

        NextArea.SetActive(true);
        NextArea.GetComponent<Renderer>().material.color = Color.green;
        NextAreaCanvas.SetActive(true);

    }

}
