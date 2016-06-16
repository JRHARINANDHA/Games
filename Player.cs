using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float UpForce;
    public float Speed;
    private Rigidbody rigidBody;
    public GameObject[] clouds;
    public Material[] sky;
    public GameObject enemy;
    public Text Score;
    public int count = 0;
    public GameObject score;
    private float min = 0;
    


    // Use this for initialization
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
        InvokeRepeating("CloudGen", 1f, 2.5f);
        InvokeRepeating("Bgchanger", 0f, 20f);
        InvokeRepeating("EnemySpawn", 5f, 6f);
        InvokeRepeating("EnemySpawn", 5f, 10f);
        InvokeRepeating("EnemySpawn1", 4f, 8f);


    }

    // Update is called once per frame
    void Update()
    {
       // transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, min, min);
    }

    void LateUpdate()
    {
        
        count = (int) Time.timeSinceLevelLoad;
        SetScore(count);
        transform.Translate(Speed * Vector3.forward);
        
        if (Input.GetMouseButton(0))
        {
            fly();
        }

       
    }
    public void fly()
    {
        rigidBody.AddForce(Vector3.up * UpForce);
    }
    void CloudGen()
    {
     
            var randoo = UnityEngine.Random.Range(-70, 70);
    var dist = transform.position + new Vector3(400, randoo, 50);
    var rando = UnityEngine.Random.Range(0, clouds.Length);

    var gameobject = Instantiate(clouds[rando], dist, Quaternion.identity);
    gameObject.SetActive(true);
            
        
    }
    void Bgchanger()
    {
        var randoo = UnityEngine.Random.Range(0,5);
        RenderSettings.skybox = sky[randoo];

    }
    void EnemySpawn1()
    {
        var randoo = UnityEngine.Random.Range(0, 25);
        var dist = transform.position + new Vector3(400, randoo, 0);
        var gameobject = Instantiate(enemy, dist, Quaternion.Euler(0, -90, 0));
    }
    void EnemySpawn()
    {
        
        var dist = transform.position + new Vector3(400, 0, 0);
        var gameobject = Instantiate(enemy, dist, Quaternion.Euler(0,-90,0));
    }

    public void SetScore(int score)
    {
        
        Score.text = "Score: " + score.ToString();
        
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Finish")||obj.CompareTag("Enemy"))
        {
            
            score.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }

   
}
