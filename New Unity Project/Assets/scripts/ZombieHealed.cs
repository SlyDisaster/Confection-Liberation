using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZombieHealed : MonoBehaviour


{
    public Sprite Human;
    public SpriteRenderer spriteRenderer;
    public GameObject scoreBoard;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Candy")
        {
            spriteRenderer.sprite = Human;

            scoreBoard.GetComponent<score>().gameScore++;

        }

        void Start()
        {
            scoreBoard = GameObject.Find("ScoreBoard");

        }


    }
}




    // Update is called once per frame
   
