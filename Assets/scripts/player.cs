using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("hey it started somehow how'd you swing that");
        //transform.Translate(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Keyboard.current.akey.isPressed)
        {
            Debug.Log("A key is pressed");
        }*/
        //transform.Rotate(0,0,rotation);
        //count = count + 1;
        //Debug.Log("hey it started"+" "+ count +"times somehow how'd you swing that");
        //Debug.Log("hey it started"+" "+ count +"times somehow how'd you swing that");
        //RotateTranslate();
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
    }
    void RotateTranslate()
    {
        //transform.Translate(0, Translate, 0);
        //transform.Rotate(0, 0, Rotation);
    }
}
