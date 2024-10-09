using UnityEngine;

public class PlaySpecificMusicOnTrigger : MonoBehaviour
{
    public AudioSource audioSource;  // Die Audio Source, die die Audiospur enthält

    void OnTriggerEnter(Collider other)
    {
        // Prüfen, ob der Player mit der Box (Trigger) kollidiert
        if (other.CompareTag("Player"))
        {
            // Musik abspielen, wenn der Player in den Trigger geht
            if (!audioSource.isPlaying)  // Überprüfen, ob die Musik nicht schon läuft
            {
                audioSource.Play();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Optional: Musik stoppen, wenn der Player den Trigger verlässt
        if (other.CompareTag("Player"))
        {
            audioSource.Stop();  // Stopp die Musik, wenn der Player die Box verlässt
        }
    }
}