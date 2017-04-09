using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stroke_4_3 : Stroke
{


    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(2.5f * .8f, i * (0.25f) * .8f));
        }
    }
}
