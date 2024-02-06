//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Inputs/Inputs.inputactions
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

public partial class @Inputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""MenuMando"",
            ""id"": ""3ac64137-016f-4848-9f5b-eb8155c6cdc8"",
            ""actions"": [
                {
                    ""name"": ""Selection"",
                    ""type"": ""Button"",
                    ""id"": ""9c96a05b-08a0-4c00-9c46-f845c39d7837"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mov"",
                    ""type"": ""Value"",
                    ""id"": ""6360090c-d155-453e-9ce9-ec8af50c5786"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""f8e09518-369d-408a-af7a-415866f25407"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24092e33-b2c2-456e-93c1-ac79136bd3b9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""direction"",
                    ""id"": ""bd4975f1-b4a7-434e-ab80-6d7bd4ef599b"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mov"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""205dca29-9ab5-45af-8f6a-48a5f6a6818a"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Mov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""bf1b55c3-4f2e-4f57-8216-d7b87dc1c102"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Mov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""592e6398-007e-492d-bbaf-3b60f9373fb6"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Mov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""72691cc6-d249-4f9b-8633-1eff86f78ef8"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Mov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b99f0413-4e4e-4e97-98ad-f55b9258210a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuTeclado"",
            ""id"": ""e3b2b234-dc61-4bb1-b7d6-adee88cc0a0a"",
            ""actions"": [
                {
                    ""name"": ""Selection"",
                    ""type"": ""Button"",
                    ""id"": ""a34e94e3-b39a-41b2-82b0-8aa18d46f26e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mov"",
                    ""type"": ""Value"",
                    ""id"": ""c24c83b4-0dcc-4ff8-abb1-2bbe042c4524"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""b4707fc4-4753-4b20-902d-785962d0850f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""direction"",
                    ""id"": ""fe219083-9a69-4d7e-9a05-7ce9681d000f"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mov"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""5b3a43b1-e939-491d-8c3c-af8e73ebd085"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Mov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""30029d54-ba1c-410c-b1e2-268d79129803"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Mov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3cddf268-0bad-4593-80c0-e11f3f87853d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Mov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d65693f9-fbd5-404e-ab3a-da7de5c76259"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Mov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""090d99b2-36d4-4638-b3c9-f1eb3b582a6d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a092b76-2c62-4a89-85a8-21624bcaef91"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GamePlayTeclado"",
            ""id"": ""3654572c-75ff-49ab-9f5a-e42abccd4074"",
            ""actions"": [
                {
                    ""name"": ""MenuPc"",
                    ""type"": ""Button"",
                    ""id"": ""f9d6348c-bb62-4377-8035-4735f21d1968"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MovPc"",
                    ""type"": ""Value"",
                    ""id"": ""95d1e13b-db53-42fb-87a2-dc85203a7750"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ActionPc"",
                    ""type"": ""Button"",
                    ""id"": ""c1fb2a7c-f070-4e84-aa02-95ae5c93731f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a05c05f8-c22c-4c6f-a1c5-54a7bd03a2e6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MenuPc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dir"",
                    ""id"": ""7b17bc1c-e275-4faa-89bd-d8bb63270ebb"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovPc"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""188ffb83-851e-475b-a655-afdc9e3818fe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovPc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f74d6d77-8a8f-4189-9307-3febdab541f6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovPc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1e98b620-0964-4dc7-a7de-e5f5be58e35c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovPc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""76c83fa5-dc33-4719-a409-716433b52936"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovPc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1f1f4a63-1363-44e7-8dc7-78a476b9a341"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionPc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GamePlayGamePad"",
            ""id"": ""4960b829-26b3-4dbe-b0aa-7f6ea6d6fb68"",
            ""actions"": [
                {
                    ""name"": ""MenuGp"",
                    ""type"": ""Button"",
                    ""id"": ""70b6e02c-ecf0-4911-bbeb-bdbd8f142173"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MovGp"",
                    ""type"": ""Value"",
                    ""id"": ""d3a5d466-db06-43f5-8bc4-4e53bb586801"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ActionGp"",
                    ""type"": ""Button"",
                    ""id"": ""6b4d3e1a-02c8-4ca3-9236-fe0453c9fcbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""abe32e47-8c4c-46fa-9688-f6f936b6f267"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MenuGp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dir"",
                    ""id"": ""8bc70140-f72c-4adb-9796-9d5727f48e36"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovGp"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""95381b38-72b4-4a35-bb8c-4466187dd857"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovGp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0dc626a5-83e7-4a3e-bd66-48232a6e7e8a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovGp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9b61fd91-9b4e-451d-8638-78db272e597e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovGp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""81bf6b8b-9e19-44e5-a3f2-311ebe79532e"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovGp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""be21a38b-6462-4fab-8a71-59083bd0e692"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionGp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": []
        }
    ]
}");
        // MenuMando
        m_MenuMando = asset.FindActionMap("MenuMando", throwIfNotFound: true);
        m_MenuMando_Selection = m_MenuMando.FindAction("Selection", throwIfNotFound: true);
        m_MenuMando_Mov = m_MenuMando.FindAction("Mov", throwIfNotFound: true);
        m_MenuMando_Start = m_MenuMando.FindAction("Start", throwIfNotFound: true);
        // MenuTeclado
        m_MenuTeclado = asset.FindActionMap("MenuTeclado", throwIfNotFound: true);
        m_MenuTeclado_Selection = m_MenuTeclado.FindAction("Selection", throwIfNotFound: true);
        m_MenuTeclado_Mov = m_MenuTeclado.FindAction("Mov", throwIfNotFound: true);
        m_MenuTeclado_Start = m_MenuTeclado.FindAction("Start", throwIfNotFound: true);
        // GamePlayTeclado
        m_GamePlayTeclado = asset.FindActionMap("GamePlayTeclado", throwIfNotFound: true);
        m_GamePlayTeclado_MenuPc = m_GamePlayTeclado.FindAction("MenuPc", throwIfNotFound: true);
        m_GamePlayTeclado_MovPc = m_GamePlayTeclado.FindAction("MovPc", throwIfNotFound: true);
        m_GamePlayTeclado_ActionPc = m_GamePlayTeclado.FindAction("ActionPc", throwIfNotFound: true);
        // GamePlayGamePad
        m_GamePlayGamePad = asset.FindActionMap("GamePlayGamePad", throwIfNotFound: true);
        m_GamePlayGamePad_MenuGp = m_GamePlayGamePad.FindAction("MenuGp", throwIfNotFound: true);
        m_GamePlayGamePad_MovGp = m_GamePlayGamePad.FindAction("MovGp", throwIfNotFound: true);
        m_GamePlayGamePad_ActionGp = m_GamePlayGamePad.FindAction("ActionGp", throwIfNotFound: true);
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

    // MenuMando
    private readonly InputActionMap m_MenuMando;
    private List<IMenuMandoActions> m_MenuMandoActionsCallbackInterfaces = new List<IMenuMandoActions>();
    private readonly InputAction m_MenuMando_Selection;
    private readonly InputAction m_MenuMando_Mov;
    private readonly InputAction m_MenuMando_Start;
    public struct MenuMandoActions
    {
        private @Inputs m_Wrapper;
        public MenuMandoActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Selection => m_Wrapper.m_MenuMando_Selection;
        public InputAction @Mov => m_Wrapper.m_MenuMando_Mov;
        public InputAction @Start => m_Wrapper.m_MenuMando_Start;
        public InputActionMap Get() { return m_Wrapper.m_MenuMando; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuMandoActions set) { return set.Get(); }
        public void AddCallbacks(IMenuMandoActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuMandoActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuMandoActionsCallbackInterfaces.Add(instance);
            @Selection.started += instance.OnSelection;
            @Selection.performed += instance.OnSelection;
            @Selection.canceled += instance.OnSelection;
            @Mov.started += instance.OnMov;
            @Mov.performed += instance.OnMov;
            @Mov.canceled += instance.OnMov;
            @Start.started += instance.OnStart;
            @Start.performed += instance.OnStart;
            @Start.canceled += instance.OnStart;
        }

        private void UnregisterCallbacks(IMenuMandoActions instance)
        {
            @Selection.started -= instance.OnSelection;
            @Selection.performed -= instance.OnSelection;
            @Selection.canceled -= instance.OnSelection;
            @Mov.started -= instance.OnMov;
            @Mov.performed -= instance.OnMov;
            @Mov.canceled -= instance.OnMov;
            @Start.started -= instance.OnStart;
            @Start.performed -= instance.OnStart;
            @Start.canceled -= instance.OnStart;
        }

        public void RemoveCallbacks(IMenuMandoActions instance)
        {
            if (m_Wrapper.m_MenuMandoActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuMandoActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuMandoActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuMandoActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuMandoActions @MenuMando => new MenuMandoActions(this);

    // MenuTeclado
    private readonly InputActionMap m_MenuTeclado;
    private List<IMenuTecladoActions> m_MenuTecladoActionsCallbackInterfaces = new List<IMenuTecladoActions>();
    private readonly InputAction m_MenuTeclado_Selection;
    private readonly InputAction m_MenuTeclado_Mov;
    private readonly InputAction m_MenuTeclado_Start;
    public struct MenuTecladoActions
    {
        private @Inputs m_Wrapper;
        public MenuTecladoActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Selection => m_Wrapper.m_MenuTeclado_Selection;
        public InputAction @Mov => m_Wrapper.m_MenuTeclado_Mov;
        public InputAction @Start => m_Wrapper.m_MenuTeclado_Start;
        public InputActionMap Get() { return m_Wrapper.m_MenuTeclado; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuTecladoActions set) { return set.Get(); }
        public void AddCallbacks(IMenuTecladoActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuTecladoActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuTecladoActionsCallbackInterfaces.Add(instance);
            @Selection.started += instance.OnSelection;
            @Selection.performed += instance.OnSelection;
            @Selection.canceled += instance.OnSelection;
            @Mov.started += instance.OnMov;
            @Mov.performed += instance.OnMov;
            @Mov.canceled += instance.OnMov;
            @Start.started += instance.OnStart;
            @Start.performed += instance.OnStart;
            @Start.canceled += instance.OnStart;
        }

        private void UnregisterCallbacks(IMenuTecladoActions instance)
        {
            @Selection.started -= instance.OnSelection;
            @Selection.performed -= instance.OnSelection;
            @Selection.canceled -= instance.OnSelection;
            @Mov.started -= instance.OnMov;
            @Mov.performed -= instance.OnMov;
            @Mov.canceled -= instance.OnMov;
            @Start.started -= instance.OnStart;
            @Start.performed -= instance.OnStart;
            @Start.canceled -= instance.OnStart;
        }

        public void RemoveCallbacks(IMenuTecladoActions instance)
        {
            if (m_Wrapper.m_MenuTecladoActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuTecladoActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuTecladoActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuTecladoActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuTecladoActions @MenuTeclado => new MenuTecladoActions(this);

    // GamePlayTeclado
    private readonly InputActionMap m_GamePlayTeclado;
    private List<IGamePlayTecladoActions> m_GamePlayTecladoActionsCallbackInterfaces = new List<IGamePlayTecladoActions>();
    private readonly InputAction m_GamePlayTeclado_MenuPc;
    private readonly InputAction m_GamePlayTeclado_MovPc;
    private readonly InputAction m_GamePlayTeclado_ActionPc;
    public struct GamePlayTecladoActions
    {
        private @Inputs m_Wrapper;
        public GamePlayTecladoActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuPc => m_Wrapper.m_GamePlayTeclado_MenuPc;
        public InputAction @MovPc => m_Wrapper.m_GamePlayTeclado_MovPc;
        public InputAction @ActionPc => m_Wrapper.m_GamePlayTeclado_ActionPc;
        public InputActionMap Get() { return m_Wrapper.m_GamePlayTeclado; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayTecladoActions set) { return set.Get(); }
        public void AddCallbacks(IGamePlayTecladoActions instance)
        {
            if (instance == null || m_Wrapper.m_GamePlayTecladoActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamePlayTecladoActionsCallbackInterfaces.Add(instance);
            @MenuPc.started += instance.OnMenuPc;
            @MenuPc.performed += instance.OnMenuPc;
            @MenuPc.canceled += instance.OnMenuPc;
            @MovPc.started += instance.OnMovPc;
            @MovPc.performed += instance.OnMovPc;
            @MovPc.canceled += instance.OnMovPc;
            @ActionPc.started += instance.OnActionPc;
            @ActionPc.performed += instance.OnActionPc;
            @ActionPc.canceled += instance.OnActionPc;
        }

        private void UnregisterCallbacks(IGamePlayTecladoActions instance)
        {
            @MenuPc.started -= instance.OnMenuPc;
            @MenuPc.performed -= instance.OnMenuPc;
            @MenuPc.canceled -= instance.OnMenuPc;
            @MovPc.started -= instance.OnMovPc;
            @MovPc.performed -= instance.OnMovPc;
            @MovPc.canceled -= instance.OnMovPc;
            @ActionPc.started -= instance.OnActionPc;
            @ActionPc.performed -= instance.OnActionPc;
            @ActionPc.canceled -= instance.OnActionPc;
        }

        public void RemoveCallbacks(IGamePlayTecladoActions instance)
        {
            if (m_Wrapper.m_GamePlayTecladoActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamePlayTecladoActions instance)
        {
            foreach (var item in m_Wrapper.m_GamePlayTecladoActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamePlayTecladoActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamePlayTecladoActions @GamePlayTeclado => new GamePlayTecladoActions(this);

    // GamePlayGamePad
    private readonly InputActionMap m_GamePlayGamePad;
    private List<IGamePlayGamePadActions> m_GamePlayGamePadActionsCallbackInterfaces = new List<IGamePlayGamePadActions>();
    private readonly InputAction m_GamePlayGamePad_MenuGp;
    private readonly InputAction m_GamePlayGamePad_MovGp;
    private readonly InputAction m_GamePlayGamePad_ActionGp;
    public struct GamePlayGamePadActions
    {
        private @Inputs m_Wrapper;
        public GamePlayGamePadActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuGp => m_Wrapper.m_GamePlayGamePad_MenuGp;
        public InputAction @MovGp => m_Wrapper.m_GamePlayGamePad_MovGp;
        public InputAction @ActionGp => m_Wrapper.m_GamePlayGamePad_ActionGp;
        public InputActionMap Get() { return m_Wrapper.m_GamePlayGamePad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayGamePadActions set) { return set.Get(); }
        public void AddCallbacks(IGamePlayGamePadActions instance)
        {
            if (instance == null || m_Wrapper.m_GamePlayGamePadActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamePlayGamePadActionsCallbackInterfaces.Add(instance);
            @MenuGp.started += instance.OnMenuGp;
            @MenuGp.performed += instance.OnMenuGp;
            @MenuGp.canceled += instance.OnMenuGp;
            @MovGp.started += instance.OnMovGp;
            @MovGp.performed += instance.OnMovGp;
            @MovGp.canceled += instance.OnMovGp;
            @ActionGp.started += instance.OnActionGp;
            @ActionGp.performed += instance.OnActionGp;
            @ActionGp.canceled += instance.OnActionGp;
        }

        private void UnregisterCallbacks(IGamePlayGamePadActions instance)
        {
            @MenuGp.started -= instance.OnMenuGp;
            @MenuGp.performed -= instance.OnMenuGp;
            @MenuGp.canceled -= instance.OnMenuGp;
            @MovGp.started -= instance.OnMovGp;
            @MovGp.performed -= instance.OnMovGp;
            @MovGp.canceled -= instance.OnMovGp;
            @ActionGp.started -= instance.OnActionGp;
            @ActionGp.performed -= instance.OnActionGp;
            @ActionGp.canceled -= instance.OnActionGp;
        }

        public void RemoveCallbacks(IGamePlayGamePadActions instance)
        {
            if (m_Wrapper.m_GamePlayGamePadActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamePlayGamePadActions instance)
        {
            foreach (var item in m_Wrapper.m_GamePlayGamePadActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamePlayGamePadActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamePlayGamePadActions @GamePlayGamePad => new GamePlayGamePadActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IMenuMandoActions
    {
        void OnSelection(InputAction.CallbackContext context);
        void OnMov(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
    public interface IMenuTecladoActions
    {
        void OnSelection(InputAction.CallbackContext context);
        void OnMov(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
    public interface IGamePlayTecladoActions
    {
        void OnMenuPc(InputAction.CallbackContext context);
        void OnMovPc(InputAction.CallbackContext context);
        void OnActionPc(InputAction.CallbackContext context);
    }
    public interface IGamePlayGamePadActions
    {
        void OnMenuGp(InputAction.CallbackContext context);
        void OnMovGp(InputAction.CallbackContext context);
        void OnActionGp(InputAction.CallbackContext context);
    }
}
