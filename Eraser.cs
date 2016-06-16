using UnityEngine;
using System.Collections;

public class Eraser : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed);
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Cloud") ||obj.CompareTag("Enemy"))
            Destroy(obj.gameObject);
    }
}
