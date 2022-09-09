using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_by_triggers : MonoBehaviour
{
    [SerializeField] private GameObject trigger1;
    bool used1 = false;

    [SerializeField] private GameObject trigger2;
    bool used2 = false;

    [SerializeField] private GameObject trigger3;
    bool used3 = false;

    [SerializeField] private GameObject trigger4;
    bool used4 = false;

    [SerializeField] private GameObject trigger5;
    bool used5 = false;

    [SerializeField] private GameObject whall;

    [SerializeField] private int answer;

    void Update()
    {
        if(trigger1.GetComponent<Animator>().GetBool("active")&& trigger2.GetComponent<Animator>().GetBool("active")&& trigger3.GetComponent<Animator>().GetBool("active")&& trigger4.GetComponent<Animator>().GetBool("active")&& trigger5.GetComponent<Animator>().GetBool("active"))
        {
            Destroy(whall);
        }
    }

}
