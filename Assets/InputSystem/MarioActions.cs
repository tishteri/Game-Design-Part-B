//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/MarioActions.inputactions
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

public partial class @MarioActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MarioActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MarioActions"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""556ae62c-29fc-4002-8818-7296c933718a"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""59f439a7-b500-46c3-99c6-44131fc99ff6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""6067b426-f05b-4097-a962-28d9dbe9af8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""jumphold"",
                    ""type"": ""Button"",
                    ""id"": ""cdba19fd-3c53-44dd-ac1f-caa7cf095e96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.3)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""click"",
                    ""type"": ""Button"",
                    ""id"": ""05fc799e-54be-4a5d-a4c0-ff19e04587d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""point"",
                    ""type"": ""Value"",
                    ""id"": ""adce857d-f872-4380-b796-1f2e979a1a74"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a3e98c6b-2560-4bd4-b252-c511a3294ed2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2fd13a71-c5d1-4222-91a7-aa38b0d13a01"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e1a7b3fc-0c02-4055-949d-4d946812e51f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5e2e2474-3990-4adf-8757-e2796a37dce7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""marioActions"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7bb0542-3fc0-46c3-b571-a2bd364a876a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""marioActions"",
                    ""action"": ""jumphold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fd07642-6bda-4ab6-af3a-62f6ca7aba9a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""marioActions"",
                    ""action"": ""click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""2230a320-0719-4292-83d1-7823ffe34e20"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""f984b716-0ddf-4532-9de2-5f1d4e573ef1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""marioActions"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""0181c9aa-79fb-4414-9bfd-33b13400bf3e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""marioActions"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""marioActions"",
            ""bindingGroup"": ""marioActions"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_move = m_gameplay.FindAction("move", throwIfNotFound: true);
        m_gameplay_jump = m_gameplay.FindAction("jump", throwIfNotFound: true);
        m_gameplay_jumphold = m_gameplay.FindAction("jumphold", throwIfNotFound: true);
        m_gameplay_click = m_gameplay.FindAction("click", throwIfNotFound: true);
        m_gameplay_point = m_gameplay.FindAction("point", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_gameplay_move;
    private readonly InputAction m_gameplay_jump;
    private readonly InputAction m_gameplay_jumphold;
    private readonly InputAction m_gameplay_click;
    private readonly InputAction m_gameplay_point;
    public struct GameplayActions
    {
        private @MarioActions m_Wrapper;
        public GameplayActions(@MarioActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_gameplay_move;
        public InputAction @jump => m_Wrapper.m_gameplay_jump;
        public InputAction @jumphold => m_Wrapper.m_gameplay_jumphold;
        public InputAction @click => m_Wrapper.m_gameplay_click;
        public InputAction @point => m_Wrapper.m_gameplay_point;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
            @jump.started += instance.OnJump;
            @jump.performed += instance.OnJump;
            @jump.canceled += instance.OnJump;
            @jumphold.started += instance.OnJumphold;
            @jumphold.performed += instance.OnJumphold;
            @jumphold.canceled += instance.OnJumphold;
            @click.started += instance.OnClick;
            @click.performed += instance.OnClick;
            @click.canceled += instance.OnClick;
            @point.started += instance.OnPoint;
            @point.performed += instance.OnPoint;
            @point.canceled += instance.OnPoint;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
            @jump.started -= instance.OnJump;
            @jump.performed -= instance.OnJump;
            @jump.canceled -= instance.OnJump;
            @jumphold.started -= instance.OnJumphold;
            @jumphold.performed -= instance.OnJumphold;
            @jumphold.canceled -= instance.OnJumphold;
            @click.started -= instance.OnClick;
            @click.performed -= instance.OnClick;
            @click.canceled -= instance.OnClick;
            @point.started -= instance.OnPoint;
            @point.performed -= instance.OnPoint;
            @point.canceled -= instance.OnPoint;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    private int m_marioActionsSchemeIndex = -1;
    public InputControlScheme marioActionsScheme
    {
        get
        {
            if (m_marioActionsSchemeIndex == -1) m_marioActionsSchemeIndex = asset.FindControlSchemeIndex("marioActions");
            return asset.controlSchemes[m_marioActionsSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnJumphold(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
    }
}