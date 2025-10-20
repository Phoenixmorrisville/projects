using Unity.VisualScripting;
using UnityEngine;

public class collect : MonoBehaviour
{
    [SerializeField] movement player;

    // Update is called once per
   
    void Update()
    {
        if (transform.position == player.transform.position)
        {
            player.coins += 1f;
            Destroy(gameObject);

        }
    }
}
