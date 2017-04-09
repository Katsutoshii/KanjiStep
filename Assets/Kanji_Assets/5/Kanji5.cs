using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanji5 : Kanji
{
    public Stroke stroke_5_1, stroke_5_2, stroke_5_3, stroke_5_4, stroke_5_5;

    override public void DraftStrokes()
    {
        print("Drafting strokes for Kanji2");
        strokes.Add(stroke_5_1);
        strokes.Add(stroke_5_2);
        strokes.Add(stroke_5_3);
        strokes.Add(stroke_5_4);
        strokes.Add(stroke_5_5);
    }
}
