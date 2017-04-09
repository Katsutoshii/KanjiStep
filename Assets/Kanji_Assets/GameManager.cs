using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public List<Kanji> kanjis;
    private Kanji current;
    public Kanji kanji1, kanji2, kanji3, kanji4, kanji5;
    List<string> kanjiTitles = new List<string>(new string[]{"Ichi","Ni","San","Shi","Go" });
    public Text captionA, captionB, captionC;
    public int kanjiNum = 0;


	// Use this for initialization
	void Start () {
        kanjis.Add(kanji1);
        kanjis.Add(kanji2);
        kanjis.Add(kanji3);
        kanjis.Add(kanji4);
        kanjis.Add(kanji5);


        current = Instantiate(kanjis[0]);
        current.enabled = true;
        current.transform.parent = transform;
    }
	
	// Update is called once per frame
	void Update () {
        if (kanjiNum == 0)
        {
            captionA.text = "One";
            captionB.text = "Ichi";
            captionC.text = "いち";
        }
        if (kanjiNum == 1)
        {
            captionA.text = "Two";
            captionB.text = "Ni";
            captionC.text = "に";
        }
        if (kanjiNum == 2)
        {
            captionA.text = "Three";
            captionB.text = "San";
            captionC.text = "さん";
        }
        if (kanjiNum == 3)
        {
            captionA.text = "Four";
            captionB.text = "Yon";
            captionC.text = "よん";
        }
        if (kanjiNum == 4)
        {
            captionA.text = "Five";
            captionB.text = "Go";
            captionC.text = "ご";
        }

        if (current.completed)
        {
            if (kanjiNum < kanjis.Count - 1)
            {

                print("Kanji complete! Moving on to next...");
                kanjiNum++;
                Destroy(current);
                current = Instantiate(kanjis[kanjiNum]);
                current.enabled = true;
                current.transform.parent = transform;

            }
            else
            {
                print("Game completed!");
      
            }
        }
    }
}
