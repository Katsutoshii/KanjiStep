using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanji : MonoBehaviour {
    public List<Stroke> strokes;
    public bool completed = false;
    private Stroke current;
    public int strokeNum = 0;

    // Use this for initialization
    void Start()
    {
        DraftStrokes();
        
        current = Instantiate(strokes[0]);
        current.enabled = true;
        current.transform.parent = transform;

    }

    virtual public void DraftStrokes()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (current.completed) {
            if (strokeNum < strokes.Count - 1)
            {
                strokeNum++;
                current = Instantiate(strokes[strokeNum]);
                current.transform.parent = transform;
            }
            else
            {
                print("Kanji completed!");
                completed = true;
                gameObject.SetActive(false);            }
        }
    }
}
