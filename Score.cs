using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text hiText;
    public Text scores;

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.Find("Player");
        Player score = player.GetComponent<Player>();
        int count = score.count;
        scores.text = "Your Score: " + count.ToString();
        int hiScore = PlayerPrefs.GetInt("hiScore", 0);
        if (count >= hiScore)
        {
            PlayerPrefs.SetInt("hiScore", count);
        }
        hiText.text = "Hi-Score: " + PlayerPrefs.GetInt("hiScore", 0).ToString();
    }

    // Update is called once per frame
    void Update () {
	
	}
   
}
