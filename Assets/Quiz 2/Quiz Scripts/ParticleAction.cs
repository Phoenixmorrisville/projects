using UnityEngine;

public class ParticleAction : MonoBehaviour
{
    [SerializeField] ParticleSystem spark;
    [SerializeField] ParticleSystem finish;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Collided with Obstacle!");
            spark.transform.position = collision.contacts[0].point;
            spark.Play();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("FinishLine"))
        {
            Debug.Log("Reached Finish Line!");
            finish.Play();
        }
    }
}
