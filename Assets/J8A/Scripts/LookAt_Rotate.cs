using UnityEngine;

public class LookAt_Rotate : LookAtTrigger
{
    protected override void OnRayCastEnter(GameObject obj)
    {
        //oldMaterial = obj.GetComponent<MeshRenderer>().material;
        //obj.GetComponent<MeshRenderer>().material = selectionMaterial;
    }

    protected override void OnRayCastExit(GameObject obj)
    {
        //obj.GetComponent<MeshRenderer>().material = oldMaterial;
    }
}
