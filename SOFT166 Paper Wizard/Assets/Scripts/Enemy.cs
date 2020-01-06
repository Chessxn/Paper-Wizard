using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
//create a custom event as a class
public class EnemySpawnedEvent : UnityEvent<Transform> { }

public class Enemy : MonoBehaviour
{
    public EnemySpawnedEvent onSpawn;

    private void Start()
    {
        //use the tag to find the player
        GameObject Player = GameObject.FindWithTag("Player");
        //call invoke for the onspawn custom event giving it the player transform
        onSpawn.Invoke(Player.transform);
    }
}