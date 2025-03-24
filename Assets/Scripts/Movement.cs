using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


public class Movement : MonoBehaviour
{

    [SerializeField] Rigidbody2D _rigidbody;
    public float directionX;
    public Vector2 velocity;
    private Vector2 currentVelocity;

    public void Moving(InputAction.CallbackContext context) 
    {
        directionX = context.ReadValue<float>();
    }

    private void Update()
    {
        velocity.x = currentVelocity.x;
        _rigidbody.linearVelocity = velocity;
    }

}
