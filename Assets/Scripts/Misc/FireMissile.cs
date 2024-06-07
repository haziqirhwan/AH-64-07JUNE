using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint1; // First spawn point
    public Transform spawnPoint2; // Second spawn point
    public float fireSpeed = 20;
    public AudioSource MissileAudio;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullets); // Changed to FireBullets
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireBullets(ActivateEventArgs arg)
    {
        FireBullet(spawnPoint1);
        FireBullet(spawnPoint2);
    }

    public void FireBullet(Transform spawnPoint)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedBullet, 5);

        MissileAudio.Play();
    }
}