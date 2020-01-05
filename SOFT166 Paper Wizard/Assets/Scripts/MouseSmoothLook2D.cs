using System.Collections;
using UnityEngine;

public class MouseSmoothLook2D : MonoBehaviour
{
    public Camera theCamera;
    public float smoothing = 5.0f;
    //to compensate for the artwork not facing the right way
    public float adjustmentAngle = 0.0f;

    private void Update()
    {
        //gets the screen position of the mouse pointer and converts it into a point in the game world
        Vector3 target = theCamera.ScreenToWorldPoint(Input.mousePosition);
        //gets the difference between player position and the mouse point in the game world
        Vector3 difference = target - transform.position;

        difference.Normalize();

        //calculates the angle of the difference between the mouse pointer and the player in the game world
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //creates a new rotation that includes the new calculated angle and the adjustment angle
        Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));
        //sets our new rotation by animating to it with a Linear Interpolation (lerp)
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);
    }
}
