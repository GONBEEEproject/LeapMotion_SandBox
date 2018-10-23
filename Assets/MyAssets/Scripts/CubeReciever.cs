using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeReciever : MonoBehaviour {

    private MeshRenderer renderer;

    public void Activate()
    {
        renderer.enabled = true;
    }

    public void Inactive()
    {
        renderer.enabled = false;
    }

	// Use this for initialization
	void Start () {
        renderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
