using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class WASDController : MonoBehaviour
{ 
    Rigidbody rb; //Rigidbody for the GameObject that this script

    public float moveForce = 10f; //the force we add to a GameObject

    public Key keyUp = Key.W;// keyUp for the new input system
    public Key KeyDown = Key.S;

    Keyboard keyboard = Keyboard.current;//get the keyboard input for this device
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();//searches for a component  of this type on this GameObject
    }

    void FixedUpdate()
    {
        if (keyboard[keyUp].isPressed)//new
        {
            rb.AddForce(Vector3.up * moveForce);//give the object an upward force
        }

        if (keyboard[KeyDown].isPressed)
        {
            rb.AddForce(Vector3.down * moveForce);
        }
        
         //if(Input.GetKey(KeyCode.S))//old
         //{
         //    rb.AddForce(Vector3.down * moveForce);//give the object a downward force
         //}
    }
}