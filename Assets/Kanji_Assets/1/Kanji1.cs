using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanji1 : Kanji {
    public Stroke stroke1;

    override public void DraftStrokes()
    {
        print("Drafting strokes for Kanji1");
        strokes.Add(stroke1);
    }

}
