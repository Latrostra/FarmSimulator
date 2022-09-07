using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Helpers;
using TMPro;
using static UnityEngine.InputSystem.InputAction;

public class Console : Singleton<Console>
{
    [SerializeField]
    private string prefix = string.Empty;
    [SerializeField]
    private ConsoleCommand[] commands = new ConsoleCommand[0];
    [SerializeField]
    private GameObject uiCanvas;
    [SerializeField]
    private TMP_InputField inputField;
    private DeveloperConsole developerConsole;
    private DeveloperConsole DeveloperConsole {
        get {
            if (developerConsole != null) {
                return developerConsole;
            }
            return developerConsole = new DeveloperConsole(prefix, commands);
        }
    }
    
    public void ActiveConsole(CallbackContext context) {
        if (!context.action.triggered) return;

        if (uiCanvas.activeSelf) {
            Time.timeScale = 1;
            uiCanvas.SetActive(false);
        }
        else {
            Time.timeScale = 0;
            uiCanvas.SetActive(true);
            inputField.ActivateInputField();
        }
    }

    public void ProcessCommand(string inputValue) {
        DeveloperConsole.ProcessCommand(inputValue);
        inputField.text = string.Empty;
    }
}
