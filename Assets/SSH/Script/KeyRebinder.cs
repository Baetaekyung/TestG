using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyRebinder : MonoSingleton<KeyRebinder>
{
    private InputActionRebindingExtensions.RebindingOperation _rebindingOperation;
    public void RebindKey(PlayerInput playerInput, InputAction action)
    {
        playerInput.SwitchCurrentActionMap(action.actionMap.bindings[1].ToString());
        _rebindingOperation = playerInput.actions.actionMaps[0].actions[0].PerformInteractiveRebinding()
            .Start();
        _rebindingOperation.Dispose();
    }
}
