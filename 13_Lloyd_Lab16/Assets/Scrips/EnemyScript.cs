using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    static int Scoree;
    public GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame  
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Scoree++;
            Text ScoreText = GameObject.Find("Score").GetComponent<Text>();
            ScoreText.text = "Score : "+Scoree;
        }
    }
}
    