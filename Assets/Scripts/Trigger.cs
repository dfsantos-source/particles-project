using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public string tagName = "Player";
    public UnityEvent onEnterTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagName)
        {
            onEnterTrigger.Invoke();
        }
    }

}
