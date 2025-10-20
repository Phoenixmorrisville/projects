using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private TargetController target;

    public float currentAngle = 350f;
    public float targetAngle = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = FindObjectOfType<TargetController>();
    }

    // Update is called once per frame
    void Update()
    {
        //currentAngle = transform.rotation.eulerAngles.z;
        float rotationDifference = Mathf.DeltaAngle(currentAngle, targetAngle);
        Debug.Log("Shortest Rotation: " + rotationDifference);
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("Player stopped touching the Target!");
        }
    }
}
