using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float moveSpeed;
    Vector2 moveInput;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveControllerTopDown();
    }


    void moveControllerTopDown(){
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.Translate(moveInput * Time.deltaTime * moveSpeed);
    }
}
