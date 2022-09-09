using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class signalSend : MonoBehaviour
{
    [SerializeField] int tsignal = 1;

    private UnityEvent<int> triggerEvent = new UnityEvent<int>();


    void Start()
    {
        triggerEvent.AddListener(func);
    }

    void Update()
    {
        if (GetComponent<Animator>().GetBool("active"))
        {
            triggerEvent.Invoke(tsignal);
        }
    }

    void func(int i)
    {
        Debug.Log(i);
    }
}
