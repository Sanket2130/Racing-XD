using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

    public float cSpeed;
    Vector3 position;
    public float maxiPos = 2.3f;
	// Use this for initialization
	void Start () {
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        position.x += Input.GetAxis ("Horizontal") * cSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.4f, 2.3f);
        transform.position = position;
        
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Dushman")
        {
            Destroy(gameObject);
        }
    }

}
