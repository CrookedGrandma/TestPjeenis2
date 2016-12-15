using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ThirdPersonController : MonoBehaviour {

    public static ThirdPersonController player;
    int enemyID = -1;
    int envID = -1;

    public int Enemy {
        get { return enemyID; }
        set { enemyID = value; }
    }

    public int Envi {
        get { return envID; }
        set { envID = value; }
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
            Debug.Log("Enemy Plate: " + enemyID);
        }
        if (envID != -1) {
            Debug.Log("Environment Plate: " + envID);
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            SceneManager.LoadScene("Combat");
        }
	}
}
