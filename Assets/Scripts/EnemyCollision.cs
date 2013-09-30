using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {
	
	public float List;
	void OnTriggerEnter(Collider other) {
		if(other.tag == Tags.Down){
			Vector3 positionZtop = transform.position;
			positionZtop.z = 90;
			transform.position = positionZtop;
		}
		if(other.tag == Tags.Top){
			Vector3 positionZDown = transform.position;
			positionZDown.z = -90;
			transform.position = positionZDown;
			
		}
		if(other.tag == Tags.Right){
			Vector3 positionZDown = transform.position;
			positionZDown.x = -90;
			transform.position = positionZDown;
		}
		if(other.tag == Tags.Left){
			Vector3 positionZDown = transform.position;
			positionZDown.x = 90;
			transform.position = positionZDown;
		}
		if(other.tag == Tags.Bullet){
			Instantiate(Resources.Load("Enemy" + List), transform.position, Quaternion.identity);
			Destroy(gameObject);	
		}
	}
}
