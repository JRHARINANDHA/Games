using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public int speed;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed);
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Player"))
            Destroy(obj.gameObject);
    }
}
