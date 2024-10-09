using UnityEngine;
using TMPro; // Importiere die TextMeshPro-Bibliothek

public class PointCounter : MonoBehaviour
{
    public TextMeshPro scoreText; // Verwende TextMeshPro für 3D-Text
    private int score = 0; // Punkte

    void Start()
    {
        UpdateScoreText(); // Setze den initialen Text
    }

    void OnTriggerEnter(Collider other)
    {
        // Überprüfe, ob das andere Objekt den Tag "Player" hat
        if (other.CompareTag("Player"))
        {
            score++; // Erhöhe die Punkte
            UpdateScoreText(); // Aktualisiere den Text
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Quiz Punkte: " + score.ToString(); // Aktualisiere den Text
    }
}