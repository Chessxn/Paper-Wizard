using UnityEngine;

public class MoveTowardsObject : MonoBehaviour
{
    //sets the target for the orcs to move to
    public Transform target;
    //sets the speed for the orcs
    public float speed = 5.0f;

    private void Update()
    {
        //as long as there's a target set...
        if(target != null)
        {
            //move towards it
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }
    }

}