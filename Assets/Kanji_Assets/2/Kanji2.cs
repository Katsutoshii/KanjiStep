using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanji2 : Kanji {
    public Stroke stroke2_1, stroke2_2;

    override public void DraftStrokes()
    {
        print("Drafting strokes for Kanji2");
        strokes.Add(stroke2_1);
        strokes.Add(stroke2_2);
    }
}
