using UnityEngine;
using System.Collections;

public class ThirdPersonController : MonoBehaviour {

    public static ThirdPersonController player;
    string enemy = "";

    public string Enemy {
        get { return enemy; }
        set { enemy = value; }
    }

    // Use this for initialization
    void Awake () {
        if (player != null) {
            Destroy(gameObject);
        }else {
            player = this;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (enemy != "") {
            print(enemy);
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            Application.LoadLevel("Combat");
        }
	}
}
