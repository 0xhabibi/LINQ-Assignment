using System;
using System.Collections.Generic;
using System.Linq;

public class StateGrouping
{
    //Method to group states by 3
    public static List<List<string>> GroupStatesBy3(List<string> states, int groupSize)
    {
        List<List<string>> groupedStates = new List<List<string>>();

        for (int i = 0; i < states.Count; i += groupSize)
        {
            List<string> group = states
                .Skip(i)
                .Take(groupSize)
                .ToList();
            groupedStates.Add(group);
        }

        return groupedStates;
    }

}
