using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sampling : Stroke
{

    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(-1.75f + (i * .075f), .25f + (i * .075f)));
            vector2s.Add(new Vector2(1.75f + (i * -.075f), .25f + (i * .075f)));
        }
    }
}
