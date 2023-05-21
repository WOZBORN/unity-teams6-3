using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour
{
    public AudioClip soundClip;
    public float minDelay = 1f;
    public float maxDelay = 5f;

    private AudioSource audioSource;
    private float nextPlayTime;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nextPlayTime = Time.time + GetRandomDelay();
    }

    private void Update()
    {
        if (Time.time >= nextPlayTime)
        {
            PlayRandomSound();
        }

    }

    private void PlayRandomSound()
    {
        if (soundClip != null && !audioSource.isPlaying)
        {
            audioSource.clip = soundClip;
            audioSource.PlayOneShot(audioSource.clip);
        }
    }

    private float GetRandomDelay()
    {
        return Random.Range(minDelay, maxDelay);
    }
}