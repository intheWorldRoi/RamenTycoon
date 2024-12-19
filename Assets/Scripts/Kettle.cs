using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kettle : MonoBehaviour
{
    [SerializeField] bool readyToPour;
    Animator animator;
    Pot target;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PourWater()
    {
        if (readyToPour)
        {
            animator.SetTrigger("Boil");
            target.RiseUpWater();
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pot"))
        {
            readyToPour = true;
            target = other.GetComponent<Pot>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pot"))
        {
            readyToPour = false;
            target = null;
        }

    }
}
