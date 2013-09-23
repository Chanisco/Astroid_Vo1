using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject,3);
	}
	
	// Update is called once per frame
	void Update () {
	 	transform.Translate(Vector3.forward * 100 * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.tag == Tags.Enemy){
			Destroy(gameObject);	
		}
	}
}
