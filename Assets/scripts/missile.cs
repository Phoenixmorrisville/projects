using UnityEngine;

public class missile : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;
    [SerializeField] Transform player;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        if (transform.position == player.transform.position)
        {
            Destroy(gameObject);

        }
    }
}
