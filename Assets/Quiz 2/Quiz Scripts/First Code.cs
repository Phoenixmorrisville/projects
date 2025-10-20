using UnityEngine;

public class FirstCode : MonoBehaviour
{
    [SerializeField] ParticleSystem spark;
    [SerializeField] float SpeedAmount = 10.0f;
    Rigidbody2D myrigidbody2D;
    void Start()
    {
        Debug.Log("Game Started!");
    }

    void Update()
    {
        float xmove = Input.GetAxis("Horizontal") * SpeedAmount* Time.deltaTime;
        float ymove = Input.GetAxis("Vertical") * SpeedAmount * Time.deltaTime;
        transform.Translate(xmove, ymove, 0);
       
    }

}
