using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    public float m_speed = 10f;
    public float m_liveTime = 2;
    public float m_power = 1.0f;
    protected Transform m_transform;

	// Use this for initialization
	void Start () {
        m_transform = this.transform;
        //m_transform.rotation = new Quaternion(0, 180, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        m_liveTime -= Time.deltaTime;
        if (m_liveTime <= 0)
        {
            Destroy(this.gameObject);
            m_liveTime = 2;
        }
        m_transform.Translate(new Vector3(0, m_speed * Time.deltaTime, 0));
	}
}
