// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Spacecraft"",
            ""id"": ""5d948c86-2c9e-4027-9d87-a204d9e5c0da"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""ec8aae5b-79e2-4a9b-9f75-bdf5fdc0534e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""68818423-a965-4c65-8e53-f6ca15ea2fa5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoulder Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b833649a-a11b-4dc6-bb00-da3ff7d10b2c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3662f728-cd54-41e5-be75-0ca77ffcc83a"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3ed1279-0555-4c00-aeeb-5a49ce9d90fa"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5929f419-f22e-4900-b543-bbd3c5388c29"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8d88f62c-575a-472d-8186-0f24d97b79bf"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bff24be8-ad14-4ccf-90b3-b0756a9afd08"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""565020d2-d152-40a1-bcd2-47bd55152051"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""22a2074b-dd5a-4f46-bcbf-ac62066bc8cc"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""99e0149d-edc5-45fc-948b-9f1a421e4c00"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4a83d1bf-2842-46d5-bc51-27939986b481"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""51936ed3-0ff6-4df1-adfe-2e7fd1d21e99"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""082ad1cd-b85c-44e9-8bc7-b1683e5b777e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoulder Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""96fff08f-909a-4c78-9d1c-05a659c2f6f2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Shoulder Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""18eea515-e347-421f-b894-0084a15d84f9"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Shoulder Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox Control Scheme"",
            ""bindingGroup"": ""Xbox Control Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Spacecraft
        m_Spacecraft = asset.FindActionMap("Spacecraft", throwIfNotFound: true);
        m_Spacecraft_Pause = m_Spacecraft.FindAction("Pause", throwIfNotFound: true);
        m_Spacecraft_Movement = m_Spacecraft.FindAction("Movement", throwIfNotFound: true);
        m_Spacecraft_ShoulderMovement = m_Spacecraft.FindAction("Shoulder Movement", throwIfNotFound: true);
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

    // Spacecraft
    private readonly InputActionMap m_Spacecraft;
    private ISpacecraftActions m_SpacecraftActionsCallbackInterface;
    private readonly InputAction m_Spacecraft_Pause;
    private readonly InputAction m_Spacecraft_Movement;
    private readonly InputAction m_Spacecraft_ShoulderMovement;
    public struct SpacecraftActions
    {
        private @InputMaster m_Wrapper;
        public SpacecraftActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Spacecraft_Pause;
        public InputAction @Movement => m_Wrapper.m_Spacecraft_Movement;
        public InputAction @ShoulderMovement => m_Wrapper.m_Spacecraft_ShoulderMovement;
        public InputActionMap Get() { return m_Wrapper.m_Spacecraft; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpacecraftActions set) { return set.Get(); }
        public void SetCallbacks(ISpacecraftActions instance)
        {
            if (m_Wrapper.m_SpacecraftActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnPause;
                @Movement.started -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnMovement;
                @ShoulderMovement.started -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnShoulderMovement;
                @ShoulderMovement.performed -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnShoulderMovement;
                @ShoulderMovement.canceled -= m_Wrapper.m_SpacecraftActionsCallbackInterface.OnShoulderMovement;
            }
            m_Wrapper.m_SpacecraftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @ShoulderMovement.started += instance.OnShoulderMovement;
                @ShoulderMovement.performed += instance.OnShoulderMovement;
                @ShoulderMovement.canceled += instance.OnShoulderMovement;
            }
        }
    }
    public SpacecraftActions @Spacecraft => new SpacecraftActions(this);
    private int m_XboxControlSchemeSchemeIndex = -1;
    public InputControlScheme XboxControlSchemeScheme
    {
        get
        {
            if (m_XboxControlSchemeSchemeIndex == -1) m_XboxControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Xbox Control Scheme");
            return asset.controlSchemes[m_XboxControlSchemeSchemeIndex];
        }
    }
    public interface ISpacecraftActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnShoulderMovement(InputAction.CallbackContext context);
    }
}
