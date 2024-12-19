using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnHoverEntered() => print(gameObject.name + " - OnHoverEntered");
    public void OnHoverExited() => print(gameObject.name + " - OnHoverExited");
    public void OnSelectEntered() => print(gameObject.name + " - OnSelectEntered");
}
