using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public int collected;

    void Start()
    {
        collected = 0;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "Collectable")
        {
            colliderInfo.gameObject.SetActive(false);
            collected = collected + 1;
        }
    }
}
