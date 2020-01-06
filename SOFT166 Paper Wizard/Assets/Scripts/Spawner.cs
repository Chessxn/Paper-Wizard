using UnityEngine;

public class Spawner : MonoBehaviour
{
    //thing we are making
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;

    public void Spawn()
    {
        //get our current rotation in degrees
        Vector3 rotationInDegrees = transform.eulerAngles;
        //add the adjustment angle
        rotationInDegrees.z += adjustmentAngle;

        //convert rotation to radians
        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);

        //spawn the thing!
        Instantiate(prefabToSpawn, transform.position, rotationInRadians);
    }
}
