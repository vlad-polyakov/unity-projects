using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour {
	[SerializeField] private GameObject fireballPrefab;
	private GameObject fireball;
	public float speed = 3f;
	private float intoWall = 5f;
	private bool life;
	// Use this for initialization
	void Start () {
		life = true;
	}

	void Update () {
		if(life){
		transform.Translate (0, 0, speed * Time.deltaTime);
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		if(Physics.SphereCast(ray, 0.75f, out hit)){
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.GetComponent<PlayerCharacter> ()) {
					if (fireball == null) {
						fireball = Instantiate (fireballPrefab) as GameObject;
						fireball.transform.position = transform.TransformPoint (Vector3.forward * 1.5f);
						fireball.transform.rotation = transform.rotation;
					}
				}
				else if (hit.distance < intoWall) {
					float angle = Random.Range (-110, 110);
					transform.Rotate (0, angle, 0);
				}
			}
		}
	}
	public void SetAlive(bool life){
		this.life = life;
	}
}
