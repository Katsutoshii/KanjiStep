using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stroke_3_3 : Stroke
{


    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(i * (0.2f), -1f));
        }
    }
}
