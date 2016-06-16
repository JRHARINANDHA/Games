using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left);
	}
    void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Eraser"))
            Destroy(gameObject);
    }
}
