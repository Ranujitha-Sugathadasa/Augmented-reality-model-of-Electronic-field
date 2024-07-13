using UnityEngine;

public class BasicSceneMusic : MonoBehaviour
{
    public AudioClip basicMusicClip; // Public variable for assigning Basic scene music

    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();  // Removed using statement
        if (audioSource != null)
        {
            audioSource.clip = basicMusicClip;
            audioSource.Play();
        }
    }

    void OnDestroy()
    {
        AudioSource audioSource = GetComponent<AudioSource>();  // Removed using statement
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}
