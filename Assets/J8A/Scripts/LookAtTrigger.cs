using UnityEngine;

public class LookAtTrigger : MonoBehaviour
{
    public float selectionDistance = 1.0f;
    public LayerMask layerMask;

    private GameObject currentTarget;

    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, selectionDistance, layerMask))
        {
            if (currentTarget == null)
            {
                currentTarget = hit.transform.gameObject;
                OnRayCastEnter((currentTarget));
            }
            else if (currentTarget != hit.transform.gameObject)
            {
                OnRayCastExit(currentTarget);
                currentTarget = hit.transform.gameObject;
                OnRayCastEnter(currentTarget);
            }
            
            OnRayCast(hit.transform.gameObject);
        }
        else if (currentTarget != null)
        {
            OnRayCastExit(currentTarget);
            currentTarget = null;
        }
    }

    protected virtual void OnRayCastEnter(GameObject obj) {}
    protected virtual void OnRayCastExit(GameObject obj) {}
    protected virtual void OnRayCast(GameObject target) {}
    
}