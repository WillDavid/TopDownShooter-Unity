using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float speedEnemy;

    GameObject player;
    Animator anim;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        MoveToThePlayer();
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Bullet"){
            anim.SetBool("Dead", true);
            speedEnemy = 0;
            Destroy(gameObject, 1);
            gameObject.tag = "Finish";   
        } 
    }

    void MoveToThePlayer(){
        if (player != null) {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speedEnemy * Time.deltaTime);

            
        }
    }

}
