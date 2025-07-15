using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject SpawnBullet;
    public GameObject Bullet;
    public float SpeedBullet;
    public AudioSource ShotAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(Bullet, SpawnBullet.transform.position, SpawnBullet.transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = SpawnBullet.transform.up * Time.deltaTime * SpeedBullet;
            ShotAudio.Play();
        }
    }
}
