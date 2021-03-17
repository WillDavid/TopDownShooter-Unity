using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    SpriteRenderer spriteGun;

    [SerializeField] GameObject bullet;
    [SerializeField] Transform spawnBullet;
    
    void Start()
    {
        spriteGun = GetComponent<SpriteRenderer>();
        
    }

    
    void Update()
    {
        Aim();
        Shoot();
    }
    void Shoot(){
        if(Input.GetButtonDown("Fire1")){
            Instantiate(bullet, spawnBullet.position, transform.rotation);
        }
    }

    void Aim(){
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 offSet = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);
        float angle = Mathf.Atan2(offSet.y, offSet.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);

        if(mousePos.x < screenPoint.x ){
            spriteGun.flipY = true;
        }else{
            spriteGun.flipY = false;
        }

    }

}
