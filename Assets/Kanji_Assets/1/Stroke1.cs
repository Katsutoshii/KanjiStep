using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stroke1 : Stroke
{
    override public void DraftInstances()
    {
        print("Drafting stroke 1...");
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(i * (0.2f), 0));
        }
    }
}
