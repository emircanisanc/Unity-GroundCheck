using UnityEngine;
using UnityEngine.Events;

public class GroundCheck : MonoBehaviour
{
    // checks from here if the object is on the ground 
    // for example, it should be a point near the character's foot
    [SerializeField] private Transform GroundCheckTransform;
    // radius of the control, lower values ​​such as 0.1 give more accurate results
    [SerializeField] private float radius;
    // accepts objects in this layer as grounds
    [SerializeField] private LayerMask whatIsGround;
    // the current state of the object on the ground
    private bool onGround;
    // event that will run when the object lands
    [SerializeField] private UnityEvent OnLanded;

    void Update()
    {
        OnGroundCheck();
    }

    private void OnGroundCheck()
    {
        // store last onGround value before check the current state
        var lastGrounded = onGround;
        // if there is at least one object in the control it means the object is on ground
        onGround = Physics.OverlapSphere(GroundCheckTransform.position, radius, whatIsGround).Length > 0;
        if(lastGrounded == false && onGround == true)
        {
            OnLanded.Invoke();
        }
    }

    // Getter method for the current state
    public bool GetOnGround()
    {
        return onGround;
    }
}
