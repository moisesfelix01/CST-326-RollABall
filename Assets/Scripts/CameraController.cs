using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calculate the initial offset between the camera's position and the player's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame after every Update function
    void LateUpdate()
    {
         // Maintain the same offset between the camera and player throughout the game.
        transform.position = player.transform.position + offset;
    }
}
