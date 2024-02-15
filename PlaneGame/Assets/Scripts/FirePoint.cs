using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    public GameObject Bullet;
    public float BulletSpeed;
    public AudioSource Shot;

    public float FireRate = 0.15f;
    private float _timer;




    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _timer += Time.deltaTime;
            if (_timer > FireRate)
            {
                _timer = 0f;
                BulletCreation();
            }
           
        }
        
    }

    void BulletCreation()
    {
        GameObject bullet = Instantiate(Bullet, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
        Shot.Play();
        Destroy(bullet, 1f);
    }
}
