using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;
using ScriptableObjectArchitecture;

[CreateAssetMenu(fileName = "New Tool Command", menuName = "Command/DeveloperCommand/ToolCommand")]
public class ChangeToolCommand : ConsoleCommand
{
    public ToolVariable toolVariable;
    public override bool Process(string[] args) {
        if (args.Length != 1) {
            return false;
        }
        
        switch(args[0]) {
            case "shovel":
                toolVariable.Value = InventoryManager.Instance.tools[0];
                break;
            case "wheat":
                toolVariable.Value = InventoryManager.Instance.tools[1];
                break;
            case "scythe":
                toolVariable.Value = InventoryManager.Instance.tools[2];
                break;
        }

        return true;
    }
}
