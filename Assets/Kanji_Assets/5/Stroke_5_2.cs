using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stroke_5_2 : Stroke {
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(-.2f, (i * (0.15f) + .5f)) / 2f);
        }
    }
}
