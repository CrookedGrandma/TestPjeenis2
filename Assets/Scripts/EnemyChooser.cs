using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyChooser : MonoBehaviour {

    Enemy currentEnemy;
    string enemyC = "";
    bool enemyChosen;
    bool enemyFound;
    bool enemyEntered;

    public Text announce;

	// Use this for initialization
	void Start () {
        enemyC = ThirdPersonController.player.Enemy;
        enemyChosen = false;
        enemyFound = false;
        enemyEntered = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (enemyC != "") {
            print("In combat: " + enemyC);
        }
        if (!enemyChosen) {
            Enemy[] currentEnemies = Object.FindObjectsOfType<Enemy>();
            foreach (Enemy e in currentEnemies) {
                if (e.title == enemyC) {
                    currentEnemy = e;
                    enemyFound = true;
                    announce.text = "You're up against: " + currentEnemy.title;
                }
            }
            if (!enemyFound) {
                currentEnemy = null;
            }
            else if (!enemyEntered) {
                currentEnemy.pleaseEnter = true;
                enemyEntered = true;
            }
        }
	}
}
