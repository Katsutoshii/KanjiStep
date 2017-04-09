using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kanji_Bat: Stroke1 {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
// Ichi
public class Ichi : Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(i * (0.2f), 0));
        }
    }
}

// Ni
public class Ni : Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(i * (0.15f), 2f));
            vector2s.Add(new Vector2(i * (0.2f), -2f));

        }
    }
}

// San
public class San : Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(i * (0.15f), 3f));
            vector2s.Add(new Vector2(i * (0.12f), 1f));
            vector2s.Add(new Vector2(i * (0.2f), -2f));

        }
    }
}

// Yon
public class Yon : Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(-2.5f*.8f, i * (0.25f)*.8f));
            vector2s.Add(new Vector2(i * (0.25f)*.8f, 2.5f*.8f));
            vector2s.Add(new Vector2(2.5f*.8f, i * (0.25f)*.8f));
            vector2s.Add(new Vector2(i * (0.25f)*.8f, -2.5f*.8f));
            vector2s.Add(new Vector2((.1f * i - 1.5f)*.8f, ((.1f * i - 1.5f) + 3)*.8f));
            vector2s.Add(new Vector2((.1f * i + 1.5f)*.8f, (-(.1f * i + 1.5f) + 3)*.8f));
        }
    }
}

// Go
public class Go : Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(i * (0.15f), 1f));
            vector2s.Add(new Vector2(-.2f, (i * (0.15f) + .5f))/2f);
            vector2s.Add(new Vector2(i * (0.11f), .5f));
            vector2s.Add(new Vector2(1.1f, i * (.075f) - .25f));
            vector2s.Add(new Vector2(i * (0.15f), -1f));
        }
    }
}

// Roku
public class Roku : Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(0, (i*.025f) + 2.25f));
            vector2s.Add(new Vector2(i * .16f, 2f));
            vector2s.Add(new Vector2((i*.06f)-1.25f, (i * .075f) - .5f));
            vector2s.Add(new Vector2((i *.06f)+1.25f, (i * -.075f) - .5f));
        }
    }
}

// Shichi
public class Shichi : Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(-.3f, (i * .12f) + .5f)); vector2s.Add(new Vector2((i*.07f)+.5f, -1f));
            vector2s.Add(new Vector2(.1f + (i * .12f), .9f + (i*.01f)));
        }
    }
}

// Hachi
public class Hachi: Stroke
{
    override public void DraftInstances()
    {
        vector2s = new List<Vector2>();
        for (int i = -10; i < 10; i++)
        {
            vector2s.Add(new Vector2(-1.75f + (i * .075f), .25f + (i * .075f)));
            vector2s.Add(new Vector2(1.75f + (i * -.075f), .25f + (i * .075f)));
        }
    }
}