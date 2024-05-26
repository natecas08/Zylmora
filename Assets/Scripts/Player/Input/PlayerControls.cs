//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player/Input/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerGround"",
            ""id"": ""16d0f8fa-d352-435e-b64f-361e39d74e39"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""64b8397c-fb61-46c0-bed7-cf22064e2f77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""242932e4-11de-4e94-9f9f-429299e4d152"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""352e306c-58fd-45d1-ac8e-dbf7f168ccbb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7e03dcc-083c-487f-80e6-9ff372ae0c65"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57fb610c-bf83-4007-a182-1e8728e841bb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1c1d8f96-c9dc-4747-8912-cc1dc7495c23"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""065453e9-efcb-480a-9260-8de0cacec31b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8d727af2-aa5e-4b24-9b9a-4965a8c451e9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c2674ea9-9901-4e93-8997-4f86095d72ca"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""65e4684b-d87e-4e22-9a89-9e76bd447ae0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerGround
        m_PlayerGround = asset.FindActionMap("PlayerGround", throwIfNotFound: true);
        m_PlayerGround_Jump = m_PlayerGround.FindAction("Jump", throwIfNotFound: true);
        m_PlayerGround_Move = m_PlayerGround.FindAction("Move", throwIfNotFound: true);
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

    // PlayerGround
    private readonly InputActionMap m_PlayerGround;
    private List<IPlayerGroundActions> m_PlayerGroundActionsCallbackInterfaces = new List<IPlayerGroundActions>();
    private readonly InputAction m_PlayerGround_Jump;
    private readonly InputAction m_PlayerGround_Move;
    public struct PlayerGroundActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerGroundActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerGround_Jump;
        public InputAction @Move => m_Wrapper.m_PlayerGround_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGround; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGroundActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerGroundActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerGroundActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerGroundActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayerGroundActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayerGroundActions instance)
        {
            if (m_Wrapper.m_PlayerGroundActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerGroundActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerGroundActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerGroundActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerGroundActions @PlayerGround => new PlayerGroundActions(this);
    public interface IPlayerGroundActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
