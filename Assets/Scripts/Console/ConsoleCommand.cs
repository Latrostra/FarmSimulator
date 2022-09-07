using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ConsoleCommand : ScriptableObject, IConsoleCommand
{
    public string CommandWord => commandWord;

    public string commandWord = string.Empty;

    public abstract bool Process(string[] args);
}
