using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public bool canFire = true;
    public float throwForce = 500f;
    public GameObject pellet;
    public void Fire(InputAction.CallbackContext ctx)
    {
        if (!canFire)
        {
            return;
        }
        if (ctx.started)
        {
            GameObject p = Instantiate(pellet, transform.position, transform.rotation);
            p.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, throwForce));
        }
    }

    public void SetCanFire(bool cf)
    {
        canFire = cf;
    }
}
