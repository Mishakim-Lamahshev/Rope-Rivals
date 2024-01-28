using UnityEngine;
using TMPro;

public class DisplayWinner : MonoBehaviour
{
    [Tooltip("TextMeshPro - Text object to display the winner")]
    public TextMeshPro winnerText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("LeftBorder"))
        {
            DisplayWinnerOnScreen("Left Player wins!");
        }
        else if (other.CompareTag("RightBorder"))
        {
            DisplayWinnerOnScreen("Right Player wins!");
        }
    }

    private void DisplayWinnerOnScreen(string winner)
    {
        if (winnerText != null)
        {
            winnerText.text = winner;
            Debug.Log(winner);
            Time.timeScale = 0f; // Freeze the game
        }
        else
        {
            Debug.LogWarning("Text object is not assigned for displaying the winner. Make sure to assign the TextMeshPro - Text object in the inspector.");
        }
    }
}
