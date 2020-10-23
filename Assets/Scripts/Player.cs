using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] //Esto hace que el componente rigidbody sea obligatorio en este script

public class Player : MonoBehaviour
{
    [SerializeField]
    Transform cam;
    GameInputs gameInputs;

    [SerializeField, Range(0.1f, 300f)]
    float rotYspeed;

    [SerializeField, Range(0.1f, 15f)]
    float moveSpeed;
    [SerializeField, Range(0.1f, 15f)]
    float jumpForce;
    Rigidbody rb;

    [SerializeField, Range(0.1f, 15f)]
    float rayLenght;
    [SerializeField]
    Color rayColor = Color.red;
    [SerializeField]
    LayerMask jumpLayer;

    [SerializeField]
    Weapon weapon;
    
    float rotationAmountY;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gameInputs = new GameInputs();    
    }

    void Start()
    {
        //Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;    
        ACTIONS.jump.performed += _=> Jump();
        ACTIONS.fire.performed += _=> weapon.GetShot();
    }

    void OnEnable()
    {
        gameInputs.Enable();    
    }

    void OnDisable()
    {
        gameInputs.Disable();    
    }

    void Update()
    {
        //transform.Rotate(Vector3.up * LookAxis.x * rotYspeed * Time.deltaTime); 
        cam.Rotate(Vector3.right * LookAxis.y * rotYspeed * Time.deltaTime);
        //transform.Translate(MovementAxis * CheckMoveSpeed(ACTIONS.run.phase) * Time.deltaTime);

        rotationAmountY += LookAxis.x * rotYspeed * Time.deltaTime;
        rb.rotation = Quaternion.Euler(rb.rotation.x, rotationAmountY, rb.rotation.z);
        
        Vector3 forward = rb.rotation * MovementAxis;
        rb.position += forward * CheckMoveSpeed(ACTIONS.run.phase) * Time.deltaTime;

        if(ACTIONS.fire.phase == UnityEngine.InputSystem.InputActionPhase.Started)
        {
            weapon.AddForce();
            //Debug.Log("shot");
            //weapon.TargetRB.AddForce(Vector3.forward * weapon.GetDamage, ForceMode.Impulse);
        }
    }

    float CheckMoveSpeed(UnityEngine.InputSystem.InputActionPhase phase)
    {
        switch(phase)
        {
            case UnityEngine.InputSystem.InputActionPhase.Started:
                return moveSpeed * 2f;
            case UnityEngine.InputSystem.InputActionPhase.Waiting:
                return moveSpeed;
            default: 
                return 0f;
        }
    }

    void Jump()
    {
        if(!IsGrounding) return;
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    
    Vector3 MovementAxis => new Vector3(MoveAxis.x, 0f, MoveAxis.y);

    GameInputs.NormalGameplayActions ACTIONS => gameInputs.NormalGameplay;

    Vector2 LookAxis => gameInputs.NormalGameplay.Mouse.ReadValue<Vector2>();
    Vector2 MoveAxis => gameInputs.NormalGameplay.keyboard.ReadValue<Vector2>().normalized;

    bool IsGrounding => Physics.Raycast(transform.position, -transform.up, rayLenght, jumpLayer);

    void OnDrawGizmosSelected() 
    {
        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position, -transform.up * rayLenght);    
    }
}
