using UnityEngine;
using UnityEngine.Events;

public class ProximityHazard : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Explorer playerExplorer;
    public UnityEvent onTrappedEntered;
    public UnityEvent onTrappedExited;
    bool isCurrentlyOnTrap = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If we were not on the trap and have just stepped onto it
        if (playerRenderer.bounds.Contains(transform.position)
            && !isCurrentlyOnTrap)
        {
            //Then we are now on the trap and we take damage
           onTrappedEntered.Invoke();
            isCurrentlyOnTrap = true;
        }

        //If we were on the trap and have just stepped off of it
        if (!playerRenderer.bounds.Contains(transform.position)
            && isCurrentlyOnTrap)
        {
            //Then we are no longer on the trap and it resets
           onTrappedExited.Invoke();
            isCurrentlyOnTrap = false;
        }
    }
}