using UnityEngine;
using System.Collections;

public class ThirdPersonController : MonoBehaviour {

    public static ThirdPersonController player;
    int enemyID = -1;

    public int Enemy {
        get { return enemyID; }
        set { enemyID = value; }
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
        if (enemyID != -1) {
            print(enemyID);
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            Application.LoadLevel("Combat");
        }
	}
}
