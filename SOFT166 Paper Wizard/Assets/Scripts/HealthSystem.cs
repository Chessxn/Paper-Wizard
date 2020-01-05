using UnityEngine;
//so we can use the unity events system
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour
{
    //so the zombie has health that reduces when hit by a bullet
    public int health = 10;
    //creates an event called onDie
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;

    public void TakeDamage( int damage)
    {
        //reduces health by damage quantity
        health -= damage;

        //invoke ondamaged with updated health
        onDamaged.Invoke(health);
        //if health is zero or fewer
        if (health < 1)
        {
            //if there's no health, die
            onDie.Invoke();
        }
    }
}