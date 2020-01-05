using UnityEngine;

public class SmoothLookAtTarget2D : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5.0f;
    public float adjustmentAngle = 0.0f;

    private void Update()
    {
        //as long as there's a target...
        if (target != null)
        {
            //get the difference between orc and player positions
            Vector3 difference = target.position = transform.position;
            //get our z-axis rotation
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            //create a new rotation adding new z axis and adjustment angle
            Quaternion newRot = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));
            //animate to new rotation using a lerp
            transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * smoothing);
        }
    }
}
