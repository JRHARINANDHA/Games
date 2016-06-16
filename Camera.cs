using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public int Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(1, 45, 1) * Time.deltaTime *0.75f);
       // transform.Translate(Speed * Vector3.forward);
    }
}
