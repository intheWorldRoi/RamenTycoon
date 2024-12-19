using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    BoilControl BC;
    Animator anim;

    bool InWater;
    // Start is called before the first frame update
    void Start()
    {
        BC = transform.Find("Water").GetComponent<BoilControl>();
        anim = GetComponent<Animator>();
        //BC.StartBoilAnimation();
    }

    public void Put(IngredientBase ingredient)
    {
        switch (ingredient.type)
        {
            case IngredientType.Water:
                break;
            case IngredientType.Noodle:
                break;
            case IngredientType.Powder:
                break;
            case IngredientType.Egg:
                break;
            case IngredientType.GreenOnion:
                break;
        }

    }

    public bool RiseUpWater()
    {
        if (InWater) return false;
        
        InWater = true;
        anim.SetTrigger("Rise");

        return true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
