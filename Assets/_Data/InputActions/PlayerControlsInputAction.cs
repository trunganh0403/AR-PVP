//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Data/InputActions/PlayerControlInputAction.inputactions
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

public partial class @PlayerControlInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlInputAction"",
    ""maps"": [
        {
            ""name"": ""PlayerControlsMap"",
            ""id"": ""bde6a547-0304-4fb4-b833-f590be1cb491"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""71275278-81db-47ba-9d25-669682143053"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""44e1fd89-515b-49c0-85b6-bf49ed73b24a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootAngle"",
                    ""type"": ""Value"",
                    ""id"": ""2290edc1-144b-432b-83e7-2f2c001eb7fd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5f56fee2-b4b8-4ee9-97ae-6bba4f76e9a1"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f5c59f11-2657-4794-a592-69706ac5c67d"",
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
                    ""id"": ""3f2cf97e-7a1a-458e-af5c-d13d0856500f"",
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
                    ""id"": ""85e59e73-ccd0-4adc-9f65-ac06d66ce1f2"",
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
                    ""id"": ""e4eb8f62-7162-4f5e-953a-dbe6797da582"",
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
                    ""id"": ""768d6929-0fa8-41b8-b020-a040c0297ca8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8c8bea8a-d1b4-43f4-b9ca-34da0e7b7714"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44a906e6-731a-4694-80ef-8bb8f95f4197"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootAngle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControlsMap
        m_PlayerControlsMap = asset.FindActionMap("PlayerControlsMap", throwIfNotFound: true);
        m_PlayerControlsMap_Move = m_PlayerControlsMap.FindAction("Move", throwIfNotFound: true);
        m_PlayerControlsMap_Shoot = m_PlayerControlsMap.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerControlsMap_ShootAngle = m_PlayerControlsMap.FindAction("ShootAngle", throwIfNotFound: true);
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

    // PlayerControlsMap
    private readonly InputActionMap m_PlayerControlsMap;
    private List<IPlayerControlsMapActions> m_PlayerControlsMapActionsCallbackInterfaces = new List<IPlayerControlsMapActions>();
    private readonly InputAction m_PlayerControlsMap_Move;
    private readonly InputAction m_PlayerControlsMap_Shoot;
    private readonly InputAction m_PlayerControlsMap_ShootAngle;
    public struct PlayerControlsMapActions
    {
        private @PlayerControlInputAction m_Wrapper;
        public PlayerControlsMapActions(@PlayerControlInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControlsMap_Move;
        public InputAction @Shoot => m_Wrapper.m_PlayerControlsMap_Shoot;
        public InputAction @ShootAngle => m_Wrapper.m_PlayerControlsMap_ShootAngle;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControlsMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControlsMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @ShootAngle.started += instance.OnShootAngle;
            @ShootAngle.performed += instance.OnShootAngle;
            @ShootAngle.canceled += instance.OnShootAngle;
        }

        private void UnregisterCallbacks(IPlayerControlsMapActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @ShootAngle.started -= instance.OnShootAngle;
            @ShootAngle.performed -= instance.OnShootAngle;
            @ShootAngle.canceled -= instance.OnShootAngle;
        }

        public void RemoveCallbacks(IPlayerControlsMapActions instance)
        {
            if (m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControlsMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControlsMapActions @PlayerControlsMap => new PlayerControlsMapActions(this);
    public interface IPlayerControlsMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnShootAngle(InputAction.CallbackContext context);
    }
}
