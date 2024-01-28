using UnityEngine;
using UnityEngine.InputSystem;

public class TugOfWarController : MonoBehaviour
{
    public float pullForce = 10f; // Adjust the force as needed

    [Tooltip("InputAction for player pull")]
    public InputAction playerPullAction; // InputAction for player 1 pull

    [Tooltip("Direction of pull (1 for right, -1 for left)")]
    [Range(-1f, 1f)]
    public float pullDirection = 1f; // Direction of pull (1 for right, -1 for left)

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Bind the method to the input action's callback
        playerPullAction.performed += ctx => PullRope();
    }

    void OnEnable()
    {
        // Enable the input action when the script is enabled
        playerPullAction.Enable();
    }

    void OnDisable()
    {
        // Disable the input action when the script is disabled
        playerPullAction.Disable();
    }

    void PullRope()
    {
        // Apply force in the specified direction
        Vector2 force = new Vector2(pullDirection * pullForce, 0f);

        // Apply force to the Rigidbody
        rb.AddForce(force, ForceMode2D.Impulse);
    }
}
