// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ControlInput
{
    public class @ControlInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @ControlInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""6a3650f1-d46f-48f5-b09f-2e894328a7dd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b2f8e6c9-114d-4757-89e2-0b44627854aa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""febd8e0f-53a1-4b43-8d7d-93871ac35446"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""b73764ed-d405-4e59-ba66-7f7dcbd0ca45"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""QuickUtility"",
                    ""type"": ""Button"",
                    ""id"": ""cb1f9dd9-b1fb-4faa-9681-799cdf511f1a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetailedUtility"",
                    ""type"": ""Button"",
                    ""id"": ""043e0bed-2f9d-418e-a033-3ae3ebd2bf05"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PageUp"",
                    ""type"": ""Button"",
                    ""id"": ""f6c0aea8-8289-4101-892c-988afd0dc7f2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PageDown"",
                    ""type"": ""Button"",
                    ""id"": ""86a4a472-abf7-4b2a-9692-eb33c3e30938"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExitMenu"",
                    ""type"": ""Button"",
                    ""id"": ""2c9f62c4-05b6-4e1d-90b7-e00b6bb21241"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""36519dc9-f7c1-42cd-910e-971ca02e98d7"",
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
                    ""id"": ""303f9ee1-00a6-4639-89de-a48c152a835f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f465c665-e40c-4b67-9a23-cd096456bd13"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""18ac57a9-edab-4284-af5c-85f5a3d41d59"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""30554298-bde6-4505-bd1a-6c00be7148ae"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1fcb30a2-dc70-4681-aca5-3ca5b542f73e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f632b582-9809-44d4-ad40-46c9696c56d6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c12dbcad-1995-4f1f-ba58-bb131360c293"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a9e5a45f-e63f-415f-8d4e-934a50adada5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2b0dcd4f-384f-428c-9b60-c8e042848d25"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c2f155f-a2d8-48b4-9bb6-33c53f73800f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""551c3f25-a36b-4c3b-9dda-7a7b0a90e8f5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a28603d3-089e-4547-8f38-817b6acdef8f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ceef2d9-9dec-4d21-ad0e-3963fac87773"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cf89076-a0ac-4ff1-a017-48c2c9094526"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""QuickUtility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aba2648-0e00-4224-b346-c4a722043dbf"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DetailedUtility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b44d406d-0fdb-45f3-b26e-9045d66d5b6d"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PageUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c2b7406-02f3-4b45-8be1-dee1271ac2a0"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PageDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aeb55299-6c96-48f8-b280-718b24530a1e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ExitMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c151124-6d62-46cd-99cc-62f0e71680f0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""ExitMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
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
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_Move = m_Menu.FindAction("Move", throwIfNotFound: true);
            m_Menu_Confirm = m_Menu.FindAction("Confirm", throwIfNotFound: true);
            m_Menu_Cancel = m_Menu.FindAction("Cancel", throwIfNotFound: true);
            m_Menu_QuickUtility = m_Menu.FindAction("QuickUtility", throwIfNotFound: true);
            m_Menu_DetailedUtility = m_Menu.FindAction("DetailedUtility", throwIfNotFound: true);
            m_Menu_PageUp = m_Menu.FindAction("PageUp", throwIfNotFound: true);
            m_Menu_PageDown = m_Menu.FindAction("PageDown", throwIfNotFound: true);
            m_Menu_ExitMenu = m_Menu.FindAction("ExitMenu", throwIfNotFound: true);
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

        // Menu
        private readonly InputActionMap m_Menu;
        private IMenuActions m_MenuActionsCallbackInterface;
        private readonly InputAction m_Menu_Move;
        private readonly InputAction m_Menu_Confirm;
        private readonly InputAction m_Menu_Cancel;
        private readonly InputAction m_Menu_QuickUtility;
        private readonly InputAction m_Menu_DetailedUtility;
        private readonly InputAction m_Menu_PageUp;
        private readonly InputAction m_Menu_PageDown;
        private readonly InputAction m_Menu_ExitMenu;
        public struct MenuActions
        {
            private @ControlInput m_Wrapper;
            public MenuActions(@ControlInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Menu_Move;
            public InputAction @Confirm => m_Wrapper.m_Menu_Confirm;
            public InputAction @Cancel => m_Wrapper.m_Menu_Cancel;
            public InputAction @QuickUtility => m_Wrapper.m_Menu_QuickUtility;
            public InputAction @DetailedUtility => m_Wrapper.m_Menu_DetailedUtility;
            public InputAction @PageUp => m_Wrapper.m_Menu_PageUp;
            public InputAction @PageDown => m_Wrapper.m_Menu_PageDown;
            public InputAction @ExitMenu => m_Wrapper.m_Menu_ExitMenu;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void SetCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                    @Confirm.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                    @Confirm.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                    @Confirm.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                    @Cancel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                    @QuickUtility.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuickUtility;
                    @QuickUtility.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuickUtility;
                    @QuickUtility.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuickUtility;
                    @DetailedUtility.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDetailedUtility;
                    @DetailedUtility.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDetailedUtility;
                    @DetailedUtility.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDetailedUtility;
                    @PageUp.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPageUp;
                    @PageUp.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPageUp;
                    @PageUp.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPageUp;
                    @PageDown.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPageDown;
                    @PageDown.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPageDown;
                    @PageDown.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPageDown;
                    @ExitMenu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnExitMenu;
                    @ExitMenu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnExitMenu;
                    @ExitMenu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnExitMenu;
                }
                m_Wrapper.m_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Confirm.started += instance.OnConfirm;
                    @Confirm.performed += instance.OnConfirm;
                    @Confirm.canceled += instance.OnConfirm;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                    @QuickUtility.started += instance.OnQuickUtility;
                    @QuickUtility.performed += instance.OnQuickUtility;
                    @QuickUtility.canceled += instance.OnQuickUtility;
                    @DetailedUtility.started += instance.OnDetailedUtility;
                    @DetailedUtility.performed += instance.OnDetailedUtility;
                    @DetailedUtility.canceled += instance.OnDetailedUtility;
                    @PageUp.started += instance.OnPageUp;
                    @PageUp.performed += instance.OnPageUp;
                    @PageUp.canceled += instance.OnPageUp;
                    @PageDown.started += instance.OnPageDown;
                    @PageDown.performed += instance.OnPageDown;
                    @PageDown.canceled += instance.OnPageDown;
                    @ExitMenu.started += instance.OnExitMenu;
                    @ExitMenu.performed += instance.OnExitMenu;
                    @ExitMenu.canceled += instance.OnExitMenu;
                }
            }
        }
        public MenuActions @Menu => new MenuActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_KeyboardandMouseSchemeIndex = -1;
        public InputControlScheme KeyboardandMouseScheme
        {
            get
            {
                if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
                return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
            }
        }
        public interface IMenuActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnConfirm(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnQuickUtility(InputAction.CallbackContext context);
            void OnDetailedUtility(InputAction.CallbackContext context);
            void OnPageUp(InputAction.CallbackContext context);
            void OnPageDown(InputAction.CallbackContext context);
            void OnExitMenu(InputAction.CallbackContext context);
        }
    }
}
