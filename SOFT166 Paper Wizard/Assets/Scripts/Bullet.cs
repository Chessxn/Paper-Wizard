using UnityEngine;

public class Bullet : MonoBehaviour
{
    //speed of bullet
    public float moveSpeed = 100.00f;
    //damage the bullet does
    public int damage = 1;

    private void Start()
    {
        //make it move when it spawns
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //tell the game object we hit to take damage and destroy the bullet
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        Die();
    }

    private void OnBecameInvisible()
    {
        //when it does off the screen, get rid of the bullet
        Die();
    }

    private void Die()
    {
        //method for destroying the bullet
        Destroy(gameObject);
    }
}
