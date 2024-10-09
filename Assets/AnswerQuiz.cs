using UnityEngine;

public class AnswerChecker : MonoBehaviour
{
    public bool isCorrect; // Setze dies im Inspector, um zu definieren, ob die Antwort richtig oder falsch ist
    public AudioClip correctAnswerClip; // AudioClip für die richtige Antwort
    public AudioClip wrongAnswerClip; // AudioClip für die falsche Antwort

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Überprüfen, ob der Spieler den Trigger betritt
        {
            if (isCorrect)
            {
                Debug.Log("Richtige Antwort!");
                PlaySound(correctAnswerClip); // Spiele das Audio für die richtige Antwort ab
            }
            else
            {
                Debug.Log("Falsche Antwort!");
                PlaySound(wrongAnswerClip); // Spiele das Audio für die falsche Antwort ab
            }
        }
    }

    void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip); // Spielt den Clip ab
        }
    }
}