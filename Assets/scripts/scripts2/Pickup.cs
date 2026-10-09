using System;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Action Event: wordt verstuurd als de pickup is opgepakt, met de score als waarde (bonus)
    public static event Action<int> OnPickedUp;

    // Pas per pickup aan in de Inspector (basisopdracht: 50)
    [SerializeField] private int scoreValue = 50;

    private void OnTriggerEnter(Collider other)
    {
        // Alleen reageren op de speler
        if (other.GetComponent<PlayerMovement>() == null)
        {
            return;
        }

        OnPickedUp?.Invoke(scoreValue);
        Destroy(gameObject);
    }
}