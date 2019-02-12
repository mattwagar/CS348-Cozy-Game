using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioSource> bassAudioSources;
    public List<AudioSource> oc0AudioSources;
    public List<AudioSource> oc1AudioSources;
    public List<AudioSource> oc2AudioSources;

    void Start()
    {
        GameObject[] bassGameObjects = GameObject.FindGameObjectsWithTag("Bass");
        foreach(GameObject bassObject in bassGameObjects)
        {
            bassAudioSources.Add(bassObject.GetComponent<AudioSource>());
        }

        GameObject[] oc0GameObjects = GameObject.FindGameObjectsWithTag("oc0");
        foreach(GameObject oc0Object in oc0GameObjects)
        {
            oc0AudioSources.Add(oc0Object.GetComponent<AudioSource>());
        }

        GameObject[] oc1GameObjects = GameObject.FindGameObjectsWithTag("oc1");
        foreach(GameObject oc1Object in oc1GameObjects)
        {
            oc1AudioSources.Add(oc1Object.GetComponent<AudioSource>());
        }

        GameObject[] oc2GameObjects = GameObject.FindGameObjectsWithTag("oc2");
        foreach(GameObject oc2Object in oc2GameObjects)
        {
            oc2AudioSources.Add(oc2Object.GetComponent<AudioSource>());
        }
    }
}
