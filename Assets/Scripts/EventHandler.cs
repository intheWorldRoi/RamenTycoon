using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction;
public class EventHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        Debug.Log($"{args.interactorObject} hovered over {args.interactableObject}");
    }

    public void HoverEvent() => print(gameObject.name + " - OnHoverEntered()");

    public void ActivateEvent() => print(gameObject.name + " - OnActivated()");
}
