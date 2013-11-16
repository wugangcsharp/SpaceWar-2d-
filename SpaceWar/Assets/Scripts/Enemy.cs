using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	protected Transform m_transform;
	public float m_speed=5;
	

	private float rotateY;
	private float rotateTimer=0f;
	// Use this for initialization
	void Start () {
		m_transform=this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		rotateTimer-=Time.deltaTime;
		m_transform.Translate(new Vector3(0,-m_speed*Time.deltaTime,0));
		if(rotateTimer<=0){
			rotateY=Random.Range(-50,50);
			m_transform.Rotate(new Vector3(0,0,rotateY)*m_speed);
			rotateTimer=1f;
		}
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.collider.CompareTag("Rocket")){
			Destroy(this.gameObject);	
		}
	}
	void OnTriggerEnter(Collider collider){
		if(collider.CompareTag("Rocket")){
			Destroy(this.gameObject);	
		}
	}
	
	void OnBecameInvisible(){
		Destroy(this.gameObject);
	}
}
