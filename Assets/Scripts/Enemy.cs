using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float Zspeed = 15f;
	public float Xspeed = 15f;
	// Update is called once per frame
	void Update () {
		transform.Translate(1 * Xspeed * Time.deltaTime, 0, 1 * Zspeed * Time.deltaTime);
	}
}
