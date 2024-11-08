using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public GameObject explosion;
    float speed = 3.0f;
    float mass = 10;
    float force = 1000;
    float acceleration;


    void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag == "tank") {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    private void Start() 
    {

    }

    void LateUpdate() 
    {
        acceleration = force / mass;
        speed += acceleration * Time.deltaTime;
        this.transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
    }
}
