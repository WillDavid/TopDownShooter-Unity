using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float moveSpeed;
    Vector2 moveInput;
    Animator animPlayerController;
    
    void Start()
    {
        animPlayerController = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        moveControllerTopDown();
        animationController();
    }


    void moveControllerTopDown(){
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.Translate(moveInput * Time.deltaTime * moveSpeed);
        
    }

    void animationController(){
        if(moveInput.x != 0 || moveInput.y != 0){
            animPlayerController.SetBool("isMoving", true);
        }else{
            animPlayerController.SetBool("isMoving", false);
        }
    }
}
