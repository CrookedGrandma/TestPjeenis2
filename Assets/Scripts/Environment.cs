using UnityEngine;
using System.Collections;

public class Environment : MonoBehaviour {
    public Color BGcolor = Color.white;

	// Use this for initialization
	void Start () {
        GetComponent<Camera>().backgroundColor = BGcolor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
