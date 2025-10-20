using UnityEngine;

public class EnemyColliision : MonoBehaviour
{
    [SerializeField] public ParticleSystem Explosion;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit player");
            Explosion.transform.position = collision.contacts[0].point;
            Explosion.Play();
            Destroy(gameObject);
        }
    }
}
