using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

[CreateAssetMenu(fileName = "New Time Command", menuName = "Command/DeveloperCommand/TimeCommand")]
public class ChangeTimeCommand : ConsoleCommand
{
    public override bool Process(string[] args) {
        var intArgs = new List<int>();
        if (args.Length != 3) {
            return false;
        }
        for(int i = 0; i < 3; i++) {
            int.TryParse(args[i], System.Globalization.NumberStyles.Integer, null, out int result);
            intArgs.Add(result);
        }

        TimeLapse.Instance.dateTime.Value.SetDMR(intArgs[0], intArgs[1], intArgs[2]);

        return true;
    }
}
