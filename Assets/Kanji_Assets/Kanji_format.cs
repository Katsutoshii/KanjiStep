using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanji_format : MonoBehaviour {

    public Object StrokeSegment1;
    public Transform Stroke_Seg;

    // Use this for initialization
    void Start() {
        Instantiate(StrokeSegment1, Stroke_Seg.position, Stroke_Seg.rotation);
        }
	
	// Update is called once per frame
		
	}

