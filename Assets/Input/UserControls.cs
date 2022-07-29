//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/UserControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @UserControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserControls"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""7f019e64-6a7b-44d6-a69a-bf75d0236859"",
            ""actions"": [
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aec4065e-2489-4e2d-8ab4-3468eb84f88f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InitiateMouse"",
                    ""type"": ""Button"",
                    ""id"": ""b0467535-7e50-4ccc-a7ed-7c0197cac9ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""2bfee0a9-6320-43e6-94e9-747d700364a2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1b255e36-1f99-4e90-97d7-c93b187a3de8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""6073104a-692a-4482-9a46-52bb0aa2878a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""38b84e4a-1f60-4a6b-afdd-8b7dfcc21e0e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bba3f163-dfdd-41a5-ab96-5ab1b27552ec"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e8a29577-657a-49a5-8001-d8e50e293ca6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""520f6585-acc9-4bbf-a5f3-fb6dbfdbae08"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""2ccdd652-e48d-4be8-a48a-c51a5a537dc3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a4816653-1fae-4451-a149-1ac21dcfb35a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f6524498-b9bb-4b3b-bcf8-2ec686b3a46a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8744e17a-8be7-422e-89fe-b9d55fa5d5ee"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""339c7be6-1308-45c1-b777-64e42e37e9b9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4c9d8a8d-6994-4381-9624-0daab9424d38"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InitiateMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""826655f5-cc0e-484b-b8d3-f0b7d5e2cbde"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_CameraMovement = m_Camera.FindAction("CameraMovement", throwIfNotFound: true);
        m_Camera_InitiateMouse = m_Camera.FindAction("InitiateMouse", throwIfNotFound: true);
        m_Camera_MousePosition = m_Camera.FindAction("MousePosition", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_CameraMovement;
    private readonly InputAction m_Camera_InitiateMouse;
    private readonly InputAction m_Camera_MousePosition;
    public struct CameraActions
    {
        private @UserControls m_Wrapper;
        public CameraActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraMovement => m_Wrapper.m_Camera_CameraMovement;
        public InputAction @InitiateMouse => m_Wrapper.m_Camera_InitiateMouse;
        public InputAction @MousePosition => m_Wrapper.m_Camera_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @CameraMovement.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraMovement;
                @InitiateMouse.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnInitiateMouse;
                @InitiateMouse.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnInitiateMouse;
                @InitiateMouse.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnInitiateMouse;
                @MousePosition.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @InitiateMouse.started += instance.OnInitiateMouse;
                @InitiateMouse.performed += instance.OnInitiateMouse;
                @InitiateMouse.canceled += instance.OnInitiateMouse;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface ICameraActions
    {
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnInitiateMouse(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}