﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {

    public string title = "";
    public bool pleaseEnter = false;
    bool hasStarted = false;

	// Use this for initialization
	void Start() {
    }
	
	// Update is called once per frame
	void Update () {
        if (pleaseEnter) {
            EnterScreen();
        }
        transform.localScale = new Vector3(Mathf.PingPong(Time.time, 0.3f) + 1, Mathf.PingPong(Time.time, 0.3f) + 1, Mathf.PingPong(Time.time, 0.3f) + 1);
    }

    public void opacity(float alpha)
    {
        Color tmp = this.GetComponent<Image>().color;
        tmp.a = alpha;
        this.GetComponent<Image>().color = tmp;
        Debug.Log("Opacity of sprite " + title + " to " + alpha);
    }

    public void EnterScreen() {
        if (!hasStarted) {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-750f, 0f);
            hasStarted = true;
        }
        else if ((this.transform.position.x / Screen.width * 16) <= 14.257080610021786492374727668845) {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            pleaseEnter = false;
        }
    }
}
