using UnityEngine;

public class QuestionTrigger : MonoBehaviour
{
    public AudioClip questionClip; // AudioClip für die Frage
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Überprüfen, ob der Spieler den Trigger betritt
        {
            PlayQuestion();
        }
    }

    void PlayQuestion()
    {
        if (audioSource != null && questionClip != null)
        {
            audioSource.PlayOneShot(questionClip); // Spielt den Clip ab
            Debug.Log("Frage gestellt!"); // Hier kannst du die Frage stellen oder weitere Logik hinzufügen
        }
    }
}