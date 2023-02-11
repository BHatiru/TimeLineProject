//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/InputSystem.inputactions
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

public partial class @InputSystem : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""CharcterMovementControls"",
            ""id"": ""afde060f-5386-4314-949a-5c6f52474f97"",
            ""actions"": [
                {
                    ""name"": ""Movement1"",
                    ""type"": ""Value"",
                    ""id"": ""0b8ecda6-9297-40b0-939c-9c8e03f00e9a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Running"",
                    ""type"": ""Button"",
                    ""id"": ""0beec94d-9e60-40ed-b4c3-641434bd126c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouching"",
                    ""type"": ""Button"",
                    ""id"": ""07370f78-981a-4f6a-9a78-9c94f6b48216"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jumping"",
                    ""type"": ""Button"",
                    ""id"": ""11e8eb03-c20f-4fec-bb85-4ec0f446a60b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Injure"",
                    ""type"": ""Button"",
                    ""id"": ""60c3dd69-999f-4147-9f1a-5e0122629445"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Ready"",
                    ""type"": ""Button"",
                    ""id"": ""2413d679-45bb-424e-b458-09394911b626"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""5593f644-dcbe-4c3b-a555-85b98c581915"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""69980fe7-ef90-4ef4-b7fe-4efd29966b2c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0ad93950-b432-4087-b83f-fafc8491bdc3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1427faf6-b678-405c-8d16-673d802bd258"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""68353ed9-bd06-4f35-b9be-0765ac1d71f9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5309df3a-2ebc-4c55-92e7-01e54c73055f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""af357cc6-92ce-48ac-9bba-f2a98e067260"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Running"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""691088f4-1891-4865-8588-d48ee0ddf3b1"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouching"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24404f7c-426b-44fb-96a5-93c7e8b6e2a5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fe88cc5-e194-4b66-b879-f43f03576a39"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Injure"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e7f09ca-1b98-46e4-9f52-c685fa097b4a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5e1d00e-5d9b-4dad-b7ea-91345a6d002b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharcterMovementControls
        m_CharcterMovementControls = asset.FindActionMap("CharcterMovementControls", throwIfNotFound: true);
        m_CharcterMovementControls_Movement1 = m_CharcterMovementControls.FindAction("Movement1", throwIfNotFound: true);
        m_CharcterMovementControls_Running = m_CharcterMovementControls.FindAction("Running", throwIfNotFound: true);
        m_CharcterMovementControls_Crouching = m_CharcterMovementControls.FindAction("Crouching", throwIfNotFound: true);
        m_CharcterMovementControls_Jumping = m_CharcterMovementControls.FindAction("Jumping", throwIfNotFound: true);
        m_CharcterMovementControls_Injure = m_CharcterMovementControls.FindAction("Injure", throwIfNotFound: true);
        m_CharcterMovementControls_Ready = m_CharcterMovementControls.FindAction("Ready", throwIfNotFound: true);
        m_CharcterMovementControls_Attack = m_CharcterMovementControls.FindAction("Attack", throwIfNotFound: true);
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

    // CharcterMovementControls
    private readonly InputActionMap m_CharcterMovementControls;
    private ICharcterMovementControlsActions m_CharcterMovementControlsActionsCallbackInterface;
    private readonly InputAction m_CharcterMovementControls_Movement1;
    private readonly InputAction m_CharcterMovementControls_Running;
    private readonly InputAction m_CharcterMovementControls_Crouching;
    private readonly InputAction m_CharcterMovementControls_Jumping;
    private readonly InputAction m_CharcterMovementControls_Injure;
    private readonly InputAction m_CharcterMovementControls_Ready;
    private readonly InputAction m_CharcterMovementControls_Attack;
    public struct CharcterMovementControlsActions
    {
        private @InputSystem m_Wrapper;
        public CharcterMovementControlsActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement1 => m_Wrapper.m_CharcterMovementControls_Movement1;
        public InputAction @Running => m_Wrapper.m_CharcterMovementControls_Running;
        public InputAction @Crouching => m_Wrapper.m_CharcterMovementControls_Crouching;
        public InputAction @Jumping => m_Wrapper.m_CharcterMovementControls_Jumping;
        public InputAction @Injure => m_Wrapper.m_CharcterMovementControls_Injure;
        public InputAction @Ready => m_Wrapper.m_CharcterMovementControls_Ready;
        public InputAction @Attack => m_Wrapper.m_CharcterMovementControls_Attack;
        public InputActionMap Get() { return m_Wrapper.m_CharcterMovementControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharcterMovementControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICharcterMovementControlsActions instance)
        {
            if (m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface != null)
            {
                @Movement1.started -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnMovement1;
                @Movement1.performed -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnMovement1;
                @Movement1.canceled -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnMovement1;
                @Running.started -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnRunning;
                @Running.performed -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnRunning;
                @Running.canceled -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnRunning;
                @Crouching.started -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnCrouching;
                @Crouching.performed -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnCrouching;
                @Crouching.canceled -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnCrouching;
                @Jumping.started -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnJumping;
                @Jumping.performed -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnJumping;
                @Jumping.canceled -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnJumping;
                @Injure.started -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnInjure;
                @Injure.performed -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnInjure;
                @Injure.canceled -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnInjure;
                @Ready.started -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnReady;
                @Ready.performed -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnReady;
                @Ready.canceled -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnReady;
                @Attack.started -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_CharcterMovementControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement1.started += instance.OnMovement1;
                @Movement1.performed += instance.OnMovement1;
                @Movement1.canceled += instance.OnMovement1;
                @Running.started += instance.OnRunning;
                @Running.performed += instance.OnRunning;
                @Running.canceled += instance.OnRunning;
                @Crouching.started += instance.OnCrouching;
                @Crouching.performed += instance.OnCrouching;
                @Crouching.canceled += instance.OnCrouching;
                @Jumping.started += instance.OnJumping;
                @Jumping.performed += instance.OnJumping;
                @Jumping.canceled += instance.OnJumping;
                @Injure.started += instance.OnInjure;
                @Injure.performed += instance.OnInjure;
                @Injure.canceled += instance.OnInjure;
                @Ready.started += instance.OnReady;
                @Ready.performed += instance.OnReady;
                @Ready.canceled += instance.OnReady;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public CharcterMovementControlsActions @CharcterMovementControls => new CharcterMovementControlsActions(this);
    public interface ICharcterMovementControlsActions
    {
        void OnMovement1(InputAction.CallbackContext context);
        void OnRunning(InputAction.CallbackContext context);
        void OnCrouching(InputAction.CallbackContext context);
        void OnJumping(InputAction.CallbackContext context);
        void OnInjure(InputAction.CallbackContext context);
        void OnReady(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}