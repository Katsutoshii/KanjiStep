using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanji3 : Kanji
{
    public Stroke stroke_3_1, stroke_3_2, stroke_3_3;

    override public void DraftStrokes()
    {
        print("Drafting strokes for Kanji3");
        strokes.Add(stroke_3_1);
        strokes.Add(stroke_3_2);
        strokes.Add(stroke_3_3);
    }
}
