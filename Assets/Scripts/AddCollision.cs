using UnityEngine;

public class AddCollision : MonoBehaviour
{


    public PlayerMovement movement;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
