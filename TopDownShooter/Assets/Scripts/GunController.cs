using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    SpriteRenderer spriteGun;
    
    void Start()
    {
        spriteGun = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        gun();
    }

    void gun(){
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
