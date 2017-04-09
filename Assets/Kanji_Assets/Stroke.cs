using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stroke : MonoBehaviour {
    public bool completed = false;
    public int hitCount = 0;
    public GameObject strokeSegment;
    public List<GameObject> instances = new List<GameObject>();
    public List<Vector2> vector2s = new List<Vector2>();

    void Awake()
    {
        DraftInstances();
        CreateInstances();
    }

    void Update()
    {
        
        if (!completed && hitCount > instances.Count / 2)
        {

            foreach (GameObject instance in instances)
            {
                instance.GetComponent<Renderer>().material.color = Color.white;
                instance.GetComponent<StrokeSegment>().touched = true;
            }
            completed = true;



        }
    }

    //to be overriden
    virtual public void DraftInstances()
    {
    }

    public void CreateInstances()
    {
        foreach (Vector2 vector2 in vector2s) {
            GameObject instance = Instantiate(strokeSegment, vector2, Quaternion.identity);
            instance.transform.parent = transform;
            instance.SetActive(true);
            
            instances.Add(instance);
            
        }
    }
}
