using UnityEngine;

public class QuizCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Crasdhed into Obstacle");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collect item");
    }
}

