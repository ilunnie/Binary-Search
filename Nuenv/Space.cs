using System;
using System.Collections.Generic;

namespace ilunnie.Nuenv;

public static class Space
{
    public static List<float> ListInOrder(float min, float max, float size)
    {
        List<float> list = new() { min };

        do list.Add((float)Utils.Rescale(Random.Shared.NextDouble(), list[^1], list[^1] + size));
        while (list[^1] - max + size < 0);

        return list;
    }
}