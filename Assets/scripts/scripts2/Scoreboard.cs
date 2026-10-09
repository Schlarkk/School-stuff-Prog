using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;

    private void Start()
    {
        textField = GetComponent<TMP_Text>();
        UpdateText();

        // Abonneren op het Action Event
        Pickup.OnPickedUp += AddScore;
    }

    private void OnDestroy()
    {
        // Stoppen met luisteren
        Pickup.OnPickedUp -= AddScore;
    }

    private void AddScore(int scoreValue)
    {
        score += scoreValue;
        UpdateText();
    }

    private void UpdateText()
    {
        textField.text = "score: " + score;
    }
}