using UnityEngine;

public class QuadMovement : MonoBehaviour
{
    public float moveDistance = 1.0f; // The distance the quad will move up and down
    public float moveSpeed = 2.0f;   // The speed of the movement

    private Vector3 initialPosition;
    private float startTime;

    private void Start()
    {
        initialPosition = transform.position;
        startTime = Time.time;
    }

    private void Update()
    {
        // Calculate the new position for the quad based on time and speed
        float newY = initialPosition.y + Mathf.Sin((Time.time - startTime) * moveSpeed) * moveDistance;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
