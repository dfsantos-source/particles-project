using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public float explodingTime = 3f;
    public float explodeRadius = 3f;
    public GameObject explodeParticle;

    private float timer = 0;
    // Update is called once per frame
    void Update()
    {
       
        if (timer >= explodingTime)
        {
            Explode();
        } else
        {
            timer += Time.deltaTime;
        }
    }

    void Explode()
    {
        Instantiate(explodeParticle, transform.position, transform.rotation);
        Collider[] colliders = Physics.OverlapSphere(transform.position, explodeRadius);
        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody rb = colliders[i].GetComponent<Rigidbody>();
            Flammable fm = colliders[i].GetComponent<Flammable>();
            if (rb != null)
            {
                rb.AddExplosionForce(1500f, transform.position, explodeRadius);
            }
            if (fm != null) {
                fm.Fire(10f);
            }
        }
        Destroy(gameObject);
    }
}
