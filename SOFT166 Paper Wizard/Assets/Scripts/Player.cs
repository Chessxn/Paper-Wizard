using UnityEngine;

public class Player : MonoBehaviour
{
    //using a delegate, other scripts can make their own custom methods that run when the event is set
    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;

    public void SendHealthData(int health)
    {
        if (OnUpdateHealth != null)
        {
            OnUpdateHealth(health);
        }
    }
}
