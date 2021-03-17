using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speedBullet;
    [SerializeField] ParticleSystem effect;

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }


    void MoveBullet(){
        transform.Translate(Vector3.right * Time.deltaTime * speedBullet);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
