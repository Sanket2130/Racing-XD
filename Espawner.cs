using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espawner : MonoBehaviour {
    public GameObject car;
    public float max = 2.4f;
    public float wait = 1f;
    float timer;
	void Start () {

        timer = wait;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 Eposition = new Vector3(Random.Range(-2.5f, 2.4f), transform.position.y, transform.position.z);

            Instantiate(car, Eposition, transform.rotation);
            timer = wait;
        }
       
    }
}
