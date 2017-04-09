using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrokeSegment : MonoBehaviour {
    
    public bool touched = false;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.gray;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && !touched)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);

            //If touch overlaps with a StrokeSegment
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                GetComponent<Renderer>().material.color = Color.white;
                gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Touched";
                touched = true;
                transform.parent.GetComponent<Stroke>().hitCount++;
            }
        }
    }
}
