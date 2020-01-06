using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBaseSpawning : MonoBehaviour
{
    //need some monsters
    public GameObject monsterA;
    public GameObject monsterB;
    public GameObject monsterC;

    public UnityEvent spawnMonster;

    public ArrayList monsters = new ArrayList();
    private float monsterValue;

    //get activated by the timerevent

    //choose a nice monster

    //tell the spawner to spawn it

    public void ChooseMonster()
    {
        monsterValue = Random.Range(0.0f, 3.0f);

        if (monsterValue<=1 && monsterA!=null)
        {
            //spawn monster a
            spawnMonster.Invoke();
        }
        else if (monsterValue>2 && monsterC!=null)
        {
            //spawn monster c
        }
        else if (monsterB !=null)
        {
            //spawn monster b
        }
        //otherwise do nothing!
    }

}
