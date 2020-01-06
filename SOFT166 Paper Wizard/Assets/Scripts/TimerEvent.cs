using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour
{
    //how long it takes for the timer to go
    public float time = 1;
    // if you want it to run forever, set to true
    public bool repeat = false;
    //when timer completes, this event will send
    public UnityEvent onTimerComplete;

    private void Start()
    {
        if (repeat)
        {
            InvokeRepeating("OnTimerComplete", 0, time);
        }
        else
        {
            Invoke("OnTimerComplete", time);
        }
    }

    private void OnTimerComplete()
    {
        onTimerComplete.Invoke();
    }
}