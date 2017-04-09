using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanji4 : Kanji
{
    public Stroke stroke_4_1, stroke_4_2, stroke_4_3, stroke_4_4, stroke_4_5, stroke_4_6;

    override public void DraftStrokes()
    {
        print("Drafting strokes for Kanji2");
        strokes.Add(stroke_4_1);
        strokes.Add(stroke_4_2);
        strokes.Add(stroke_4_3);
        strokes.Add(stroke_4_4);
        strokes.Add(stroke_4_5);
        strokes.Add(stroke_4_6);
    }
}
