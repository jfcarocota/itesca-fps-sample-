using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Weapon : MonoBehaviour
{
    [SerializeField]
    Transform rayOrigin;
    [SerializeField, Range(0.1f, 1000f)]
    float rayLenght;
    [SerializeField]
    Color rayColor = Color.yellow;
    [SerializeField]
    LayerMask hitLayer;

    Rigidbody targetRb;

    [SerializeField, Range(0.1f, 5000f)]
    float damage;

    RaycastHit hit;

    AudioSource aud;
    [SerializeField]
    AudioClip shotSfx;

    void Awake() 
    {
        aud = GetComponent<AudioSource>();    
    }

    void FixedUpdate()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, rayLenght, hitLayer))
        {
            targetRb = hit.collider.GetComponent<Rigidbody>();
        }
        else
        {
            targetRb = null;
        }    
    }

    public bool IsOnRange => Physics.Raycast(transform.position, transform.forward, rayLenght, hitLayer);

    void OnDrawGizmosSelected() 
    {
        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position, transform.forward * rayLenght);
    }

    public void GetShot()
    {
        aud.PlayOneShot(shotSfx, 5.0f);
    }

    public void AddForce()
    {
        if(!hit.collider) return;
        targetRb.AddForce(-hit.normal * damage, ForceMode.Impulse);
    }

    public float GetDamage => damage;

    public Rigidbody TargetRB => targetRb;
}
