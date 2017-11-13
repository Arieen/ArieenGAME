using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Transform personaje;
    public float separacion = 0.1f;


    
	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {

            transform.position = new Vector3(personaje.position.x + separacion, personaje.position.y, personaje.position.z - 1);

    }
}
