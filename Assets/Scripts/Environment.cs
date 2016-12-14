using UnityEngine;
using System.Collections;

public class Environment : MonoBehaviour {
    public Color Desert = Color.white;
    public Color Sea = Color.white;
    public Color Forest = Color.white;


    // Use this for initialization
    void Start () {
        GetComponent<Camera>().backgroundColor = Desert;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
