using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flammable : MonoBehaviour
{
    public GameObject fire;

    private GameObject f;
    public void Fire(float flameTime)
    {
        if (f != null)
        {
            return;
        }
        f = Instantiate(fire, transform.position, transform.rotation);
        f.transform.parent = transform;
        Destroy(f, flameTime);
    }
}
