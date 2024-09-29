using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    // Make sure both objects have 2D colliders and rigidbodies to detect collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BirdObstacle"))
        {
            // Trigger game over or any action you want
            Debug.Log("Game Over!");
            // You can call a GameOver function here to stop the game, show UI, etc.
        }
    }
}
