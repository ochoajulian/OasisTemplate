using System;
using UnityEngine;
using UnityEngine.Events;

public class ColliderTrigger : MonoBehaviour
{
    [SerializeField] private bool destroyOnTriggerEnter;
    [SerializeField] private string tagFilter;
    
    [SerializeField] private UnityEvent onTriggerEnter;
    [SerializeField] private UnityEvent onTriggerExit;

    private void OnTriggerEnter(Collider other)
    {
        //If this isn't the object with the tag we want, then get outta here.
        if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        onTriggerEnter.Invoke();

        if (destroyOnTriggerEnter)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //If this isn't the object with the tag we want, then get outta here.
        if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        onTriggerExit.Invoke();
    }
}