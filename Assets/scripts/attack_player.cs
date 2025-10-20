using UnityEngine;

public class attack_player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;
    [SerializeField] Transform square;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, square.transform.position, moveSpeed * Time.deltaTime);

        
        if (transform.position == square.transform.position)
            {
            Destroy(gameObject);
            //Explosion.transform.position = transform.position;
            //Explosion.Play();
        }
    }
    
}
