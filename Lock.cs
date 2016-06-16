using UnityEngine;
using System.Collections;

public class Lock : MonoBehaviour {
    public Transform player;
    
    public float speed;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed);
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
}
