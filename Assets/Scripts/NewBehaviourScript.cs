using System.Collections;
using UnityEngine;

public class SoundManager : MonoBehaviour 
{
    public AudioClip sound;

    private AudioSource audioSource;
    private bool isSoundPlayed = false;

    void Start () 
    {
        audioSource = GetComponent<AudioSource> ();
        StartCoroutine (PlaySound ());
    }

    IEnumerator PlaySound () 
    {
        while (true) 
        {
            float delay = Random.Range (5.0f, 10.0f);
            yield return new WaitForSeconds (delay);
            if (!isSoundPlayed) 
            {
                audioSource.clip = sound;
                audioSource.Play ();
                isSoundPlayed = true;
            }
        }
    }

    private void Update() 
    {
        if (isSoundPlayed && !audioSource.isPlaying)
        {
            isSoundPlayed = false;
        }
    }
}