using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private bool playing;
    private string lastSelected;

    private void Start()
    {
        lastSelected = "null";
        playing = false;
    }

    public void PlayAudioFromAudioSource(AudioSource source)
    {
        source.Play();
    }

    public void PlayAudioFromObjectName(string objectName)
    {
        //Check if we should play audio, and make sure object is something we want to use
        if(GetComponent<UIController>().GetIsAudioEnabled() && !playing)
        {
            if(objectName != lastSelected)
            {
                //Get object
                GameObject part = GameObject.Find(objectName);

                //Check if object exists, has an audio clip, and if something isn't already playing
                if (part && part.GetComponent<AudioSource>())
                {
                    StartCoroutine(playAudioSource(part.GetComponent<AudioSource>()));
                }
            }

            lastSelected = objectName;
        }
    }

    IEnumerator playAudioSource(AudioSource source)
    {
        //Play audio, and don't let anything else play until this clip ends
        playing = true;

        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        playing = false;
    }
}
