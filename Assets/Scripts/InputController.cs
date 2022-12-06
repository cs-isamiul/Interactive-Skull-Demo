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
    private CameraPanEvent cameraPanEvent;

    [SerializeField]
    private MouseMovementEvent mouseMovementEvent;

    [SerializeField]
    private RightMouseButtonEvent rightMouseButtonEvent;

    [SerializeField]
    private bool debugPan = false;

    [SerializeField]
    private bool debugMousePosition = false;

    [SerializeField]
    private bool debugRightClick = false;

    // Start is called before the first frame update
    void Start()
    {
        controls = new UserControls();
        controls.Camera.Enable();
        
        //subscribe inputs being performed or cancelled to methods below which will then process and notify other members
        //shows how much mouse has moved from origin, for determing rotation direction
        controls.Camera.CameraMovement.performed += OnCameraPanPerformed;
        controls.Camera.CameraMovement.canceled += OnCameraPanPerformed;

        //shows if right mouse has been pressed down
        controls.Camera.RightClick.performed += RotateWithMousePerformed;
        controls.Camera.RightClick.canceled += RotateWithMousePerformed;

        //shows where the mouse is on screen, used for raycasting
        controls.Camera.MousePosition.performed += OnMouseMovePerformed;
        controls.Camera.MousePosition.canceled += OnMouseMovePerformed;

        //quit
        //var _ = new QuitHandler(controls.Camera.Quit);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCameraPanPerformed(InputAction.CallbackContext context)
    {
        //read vector 2 input and then send the data to subscribed members
        Vector2 panInput = context.ReadValue<Vector2>();
        cameraPanEvent.Invoke(panInput.x, panInput.y);
        
        if(debugPan)
        {
            Debug.Log($"Pan Input: {panInput}");
        }
    }

    private void OnMouseMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 mouseMovement = context.ReadValue<Vector2>();
        mouseMovementEvent.Invoke(mouseMovement.x, mouseMovement.y);

        if (debugMousePosition)
        {
            Debug.Log($"Move Input: {mouseMovement}");
        }
    }

    private void RotateWithMousePerformed(InputAction.CallbackContext context)
    {
        rightMouseButtonEvent.Invoke(context.ReadValueAsButton());

        if(debugRightClick)
        {
            Debug.Log($"Right mouse held : {context.ReadValueAsButton()}");
        }
    }
}
