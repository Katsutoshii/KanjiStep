using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stroke_4_5 : Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2((.1f * i - 1.5f) * .8f, ((.1f * i - 1.5f) + 3) * .8f));
        }
    }
}
