using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    //so we can get the point and angle the bullet spawns from
    public Transform bulletSpawn;
    //time in seconds between firing bullets
    public float fireTime = 0.5f;

    //when false, a bullet can be fired.
    private bool isFiring = false;

    private void SetFiring()
    {
        isFiring = false;
    }

    private void Fire()
    {
        //stops it from firing until it's done firing
        isFiring = true;
        //creates the bullet game object
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        //if there's a sound, play it
        if(GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        //returns the isFiring bool to false after a delay of fireTime
        Invoke("SetFiring", fireTime);
    }

    private void Update()
    {
        //if the left mouse button is held down
        if (Input.GetMouseButton(0))
        {
            if (!isFiring)
            {
                Fire();
            }
        }
    }
}
