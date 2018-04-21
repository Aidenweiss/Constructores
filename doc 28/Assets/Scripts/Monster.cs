using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    public int id;
    public float spacing;

	// Use this for initialization
	void Start ()
    {
        print("i'm alive");
	}
	
	// Update is called once per frame
	void Update ()
    {
        float wave = Mathf.Sin(Time.fixedTime + id);
        transform.position = new Vector3(id * spacing, wave, 0.0f);
        
    }
    
}
