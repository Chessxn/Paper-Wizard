using System.Collections;
using UnityEngine;

public class SmoothFollow2D : MonoBehaviour
{
    //lets us set the target within Unity
    public Transform target;
    //how much it smooths the movement by (i'll set it lower later)
    public float smoothing = 5.0f;

    private void FixedUpdate()
    {
        //creates a new position variable using x and y of the target and z of the camera transform
        Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z);
        //assigns the position of the camera using a lerp animation, which is what makes it look smooth
        transform.position = Vector3.Lerp(transform.position, newPos, (smoothing * 0.001f));
    }
}
