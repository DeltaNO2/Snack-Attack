using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

public int scoreToAdd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Player") )
        {
            Debug.Log("pill");
            ScoreManager scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
            scoreManager.AddScore(scoreToAdd);
            Destroy(gameObject);

        }else
        {
            Destroy(gameObject);
        }

         
        
    
    }






}
