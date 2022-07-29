using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[Serializable]
public class CameraPanEvent : UnityEvent<float, float> { }

[Serializable]
public class MouseMovementEvent : UnityEvent<float, float> { }

[Serializable]
public class RightMouseButtonEvent : UnityEvent<bool> { }

public class InputController : MonoBehaviour
{
    private UserControls controls;

    [SerializeField]
    private CameraPanEvent cameraEvent;

    [SerializeField]
    private MouseMovementEvent mouseMovementEvent;

    [SerializeField]
    private RightMouseButtonEvent rightMouseButtonEvent;

    [SerializeField]
    private bool debug = false;

    // Start is called before the first frame update
    void Start()
    {
        controls = new UserControls();
        controls.Camera.Enable();

        //subscribe inputs being performed or cancelled to methods below which will then process and notify other members
        //shows how much mouse has moved from origin, for determing rotation direction
        controls.Camera.CameraMovement.performed += OnCameraMovePerformed;
        controls.Camera.CameraMovement.canceled += OnCameraMovePerformed;

        //shows if right mouse has been pressed down
        controls.Camera.InitiateMouse.performed += RotateWithMousePerformed;
        controls.Camera.InitiateMouse.canceled += RotateWithMousePerformed;

        //shows where the mouse is on screen, used for raycasting
        controls.Camera.MousePosition.performed += OnMouseMovePerformed;
        controls.Camera.MousePosition.canceled += OnMouseMovePerformed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCameraMovePerformed(InputAction.CallbackContext context)
    {
        //read vector 2 input and then send the data to subscribed members
        Vector2 panInput = context.ReadValue<Vector2>();
        cameraEvent.Invoke(panInput.x, panInput.y);
        
        if(debug)
        {
            Debug.Log($"Pan Input: {panInput}");
        }
    }

    private void OnMouseMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 mouseMovement = context.ReadValue<Vector2>();
        mouseMovementEvent.Invoke(mouseMovement.x, mouseMovement.y);

        if (debug)
        {
            Debug.Log($"Move Input: {mouseMovement}");
        }
    }

    private void RotateWithMousePerformed(InputAction.CallbackContext context)
    {
        rightMouseButtonEvent.Invoke(context.ReadValueAsButton());

        if(debug)
        {
            Debug.Log($"Right mouse held : {context.ReadValueAsButton()}");
        }
    }
}
