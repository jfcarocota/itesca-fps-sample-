// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GameInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""NormalGameplay"",
            ""id"": ""2a070d8d-0183-4098-9abf-b21ade570cfd"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""4feb2d58-a8c5-4e57-a201-8bc0d0fd0b53"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""keyboard"",
                    ""type"": ""Value"",
                    ""id"": ""c40416e6-1933-403b-9c00-398c97be5ce1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""run"",
                    ""type"": ""Button"",
                    ""id"": ""ca629624-ae95-4839-b717-252c052e1853"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""dc1c7af8-c5bf-4916-bc3e-ac1eb20ee8c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""fire"",
                    ""type"": ""Button"",
                    ""id"": ""7407b7ce-007d-483d-813a-ab11f9d4ad06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""04aad737-feab-43d0-9df3-89f88252d2f9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4c037742-6e79-47a2-890c-0a47d27c41aa"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""keyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9e994c69-a041-4c17-849e-77695418a2e2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0b753853-9511-434d-b76c-3f13733d1384"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""503db016-0101-4d75-9b72-eaedbdcdb017"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""309f266d-03d1-4065-b0b9-47142c2b401a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0f82a076-cfb3-4dc9-aace-7dd14bc137a1"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60ab46c4-a179-425b-b616-62cecc0bda07"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4f87b10-13e6-494f-97d1-347d870a81e8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // NormalGameplay
        m_NormalGameplay = asset.FindActionMap("NormalGameplay", throwIfNotFound: true);
        m_NormalGameplay_Mouse = m_NormalGameplay.FindAction("Mouse", throwIfNotFound: true);
        m_NormalGameplay_keyboard = m_NormalGameplay.FindAction("keyboard", throwIfNotFound: true);
        m_NormalGameplay_run = m_NormalGameplay.FindAction("run", throwIfNotFound: true);
        m_NormalGameplay_jump = m_NormalGameplay.FindAction("jump", throwIfNotFound: true);
        m_NormalGameplay_fire = m_NormalGameplay.FindAction("fire", throwIfNotFound: true);
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

    // NormalGameplay
    private readonly InputActionMap m_NormalGameplay;
    private INormalGameplayActions m_NormalGameplayActionsCallbackInterface;
    private readonly InputAction m_NormalGameplay_Mouse;
    private readonly InputAction m_NormalGameplay_keyboard;
    private readonly InputAction m_NormalGameplay_run;
    private readonly InputAction m_NormalGameplay_jump;
    private readonly InputAction m_NormalGameplay_fire;
    public struct NormalGameplayActions
    {
        private @GameInputs m_Wrapper;
        public NormalGameplayActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_NormalGameplay_Mouse;
        public InputAction @keyboard => m_Wrapper.m_NormalGameplay_keyboard;
        public InputAction @run => m_Wrapper.m_NormalGameplay_run;
        public InputAction @jump => m_Wrapper.m_NormalGameplay_jump;
        public InputAction @fire => m_Wrapper.m_NormalGameplay_fire;
        public InputActionMap Get() { return m_Wrapper.m_NormalGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalGameplayActions set) { return set.Get(); }
        public void SetCallbacks(INormalGameplayActions instance)
        {
            if (m_Wrapper.m_NormalGameplayActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnMouse;
                @keyboard.started -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnKeyboard;
                @keyboard.performed -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnKeyboard;
                @keyboard.canceled -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnKeyboard;
                @run.started -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnRun;
                @run.performed -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnRun;
                @run.canceled -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnRun;
                @jump.started -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnJump;
                @fire.started -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnFire;
                @fire.performed -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnFire;
                @fire.canceled -= m_Wrapper.m_NormalGameplayActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_NormalGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @keyboard.started += instance.OnKeyboard;
                @keyboard.performed += instance.OnKeyboard;
                @keyboard.canceled += instance.OnKeyboard;
                @run.started += instance.OnRun;
                @run.performed += instance.OnRun;
                @run.canceled += instance.OnRun;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @fire.started += instance.OnFire;
                @fire.performed += instance.OnFire;
                @fire.canceled += instance.OnFire;
            }
        }
    }
    public NormalGameplayActions @NormalGameplay => new NormalGameplayActions(this);
    public interface INormalGameplayActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnKeyboard(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
