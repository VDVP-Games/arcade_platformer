using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_by_triggers1 : MonoBehaviour
{
    [SerializeField] private GameObject trigger1;
    [SerializeField] private GameObject trigger2;
    [SerializeField] private GameObject trigger3;
    [SerializeField] private GameObject trigger4;
    [SerializeField] private GameObject trigger5;

    [SerializeField] private GameObject wall;

    void Update()
    {
        if(trigger1.GetComponent<Animator>().GetBool("active")&& 
            trigger2.GetComponent<Animator>().GetBool("active")&& 
            trigger3.GetComponent<Animator>().GetBool("active")&& 
            trigger4.GetComponent<Animator>().GetBool("active")&& 
            trigger5.GetComponent<Animator>().GetBool("active"))
        {
            Destroy(wall);
        }
    }

}
