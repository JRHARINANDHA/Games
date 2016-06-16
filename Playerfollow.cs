using UnityEngine;
using System.Collections;

public class Playerfollow : MonoBehaviour {
    public Transform player;
    public float dist;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x + 100f, transform.position.y, player.position.z - dist);
	}
}
