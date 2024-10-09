using System.Collections;
using UnityEngine;

public class AmbientAudioControl : MonoBehaviour
{
    public AudioSource ambientAudioSource;  // Die Audio Source für das Ambient-Audio
    public float fadeDuration = 2f;         // Dauer des Fadings in Sekunden

    private Coroutine fadeCoroutine;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Starte das Fade-Out, wenn der Player den Trigger betritt
            if (fadeCoroutine != null)
            {
                StopCoroutine(fadeCoroutine);  // Stoppe eventuell laufendes Fade-Out
            }
            fadeCoroutine = StartCoroutine(FadeOutAmbientAudio());
        }
    }

    IEnumerator FadeOutAmbientAudio()
    {
        float startVolume = ambientAudioSource.volume;

        // Reduziert die Lautstärke schrittweise über die angegebene Fade-Dauer
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            ambientAudioSource.volume = Mathf.Lerp(startVolume, 0, t / fadeDuration);
            yield return null;  // Warte auf den nächsten Frame
        }

        // Lautstärke auf 10 setzen und Musik stoppen
        ambientAudioSource.volume = 10;
    }
}
