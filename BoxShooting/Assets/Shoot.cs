using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Rigidbody shitPrefab;
		void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody inst;
            inst  = Instantiate(shitPrefab, transform.position, transform.rotation) as Rigidbody;
            inst.AddForce(transform.forward * 1000);
        }
	}
}
