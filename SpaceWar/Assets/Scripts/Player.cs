using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private Transform m_transform;
    private CharacterController m_character;
    private float x, y;

    private float minX = -12.12129f;
    private float minZ = -5.278712f;
    private float maxX = 12.12129f;
    private float maxZ = 9.259519f;

    private float m_timer = 0.2f;

    public Transform m_RocketTransform;
    public float speed ;
	// Use this for initialization
	void Start () {
        m_transform = this.transform;
        m_character = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Control();
	}
    void FixedUpdate()
    {
		
        m_timer -= Time.deltaTime;
        if (m_timer <= 0)
        {
            print(m_RocketTransform.rotation.x);
            m_timer = 0.2f;
            Instantiate(m_RocketTransform, m_transform.position, m_transform.rotation);
        }
    }

    private void Control()
    {
        x = Input.acceleration.x;
        y = Input.acceleration.y;

        if (m_transform.position.x < minX)
        {
            if (x < 0) x = 0;
        }
         if (m_transform.position.x > maxX)
        {
            if (x > 0) x = 0;
        }


        if (m_transform.position.y < minZ)
        {
            if (y < 0) y = 0;
        }
        if (m_transform.position.y > maxZ)
        {
            if (y > 0) y = 0;
        }

         //m_character.Move(new Vector3(x, y, 0) * speed); 
		m_transform.Translate(new Vector3(x, y, 0) * speed); 
		print(x);
    }
}
