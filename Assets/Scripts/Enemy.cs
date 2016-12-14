using UnityEngine;
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
	}

    public void EnterScreen() {
        if (!hasStarted) {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-200f, 0f);
            hasStarted = true;
        }
        else if ((this.transform.position.x / Screen.width * 16) > 14.257080610021786492374727668845) {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x - 10f, 0f);
        }
        else {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            pleaseEnter = false;
        }
    }
}
