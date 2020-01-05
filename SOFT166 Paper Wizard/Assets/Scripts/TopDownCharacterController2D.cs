using System.Collections;
using UnityEngine;

public class TopDownCharacterController2D : MonoBehaviour
{
    //character speed, public so we can edit it in unity
    public float speed = 5.0f;
    //this thing will move the hero
    Rigidbody2D rigidbody2D;

    //runs once when the game object is created
    private void Start()
    {
        //gets the rigidbody component that we put on the wizard in the inspector
        //so we can use it to move the character
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    //runs constantly while the game is running and the object exists
    private void FixedUpdate()
    {
        //gets input from the keyboard/joypad and adds movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //sets the player velocity and multiplies it by the speed
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        //makes sure the player doesn't spin uncontrollably
        //deactivates one of the features of the rigidbody
        rigidbody2D.angularVelocity = 0.0f;
    }
}
