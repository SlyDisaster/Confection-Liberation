using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZombieHealed : MonoBehaviour


{
    public Sprite Human;
    //public SpriteRenderer spriteRenderer;
    GameObject scoreBoard;
    public RuntimeAnimatorController humanAni;



    private void OnCollisionEnter(Collision collision)
    {
        scoreBoard = GameObject.Find("Score Board");
        Debug.Log("Collide ciiity");
        if (collision.gameObject.tag == "Candy")
        {

            Debug.Log("collide");
            SpriteChanger();

            scoreBoard.GetComponent<score>().gameScore++;

        }

        void Start()
        {
            scoreBoard = GameObject.Find("Score Board");

        }

        void SpriteChanger()
        {
            Debug.Log("CHANGE SPRITE");
            this.GetComponent<SpriteRenderer>().sprite = Human;
            this.GetComponent<Animator>().runtimeAnimatorController = humanAni;
        }


    }
}




    // Update is called once per frame
   
