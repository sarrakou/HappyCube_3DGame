using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
