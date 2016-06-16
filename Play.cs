using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	// Use this for initialization
	public void Begin()
    {
        SceneManager.LoadScene("Main");
    }
   
    public void Shop()
    {
        SceneManager.LoadScene("CharSelect");
    }
}
