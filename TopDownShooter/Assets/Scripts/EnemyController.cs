using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float speedEnemy;

    GameObject player;
    Animator anim;
    AudioSource audioDeadEnemy;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponentInChildren<Animator>();
        audioDeadEnemy = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        MoveToThePlayer();
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Bullet"){
            gameObject.tag = "Finish";
            speedEnemy = 0;
            anim.SetBool("Dead", true);
            Destroy(gameObject, 0.3f);
            audioDeadEnemy.Play();
        } 
    }

    void MoveToThePlayer(){
        if (player != null) {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speedEnemy * Time.deltaTime);

            
        }
    }

}
