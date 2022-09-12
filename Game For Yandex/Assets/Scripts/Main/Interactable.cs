using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;

    private bool isFocus = false;
    private Transform player;

    private bool hasInteracted = false;

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
    }

    public void OnFocused(Transform playerTransfom)
    {
        isFocus = true;
        player = playerTransfom;
        hasInteracted = false;
    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    private void Update()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);

            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }  
    }
}
