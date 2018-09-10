using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {
    public GameObject game;
    private Light m;
    private Camera k;
    private AudioListener kek;
    void Awake()
    {
        k = GetComponent<Camera>();
        kek = GetComponent<AudioListener>();
    }
	void Start () {
        m = GetComponent<Light>();
	}
	void Update()
    {

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            kek.enabled = !kek.enabled;
        }
       
        if (Input.GetKeyUp(KeyCode.A))
        {
            game.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            game.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            game.GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            game.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
	
	
}
