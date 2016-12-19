using UnityEngine;
using System.Collections;

public class StateHandler : MonoBehaviour {

    enum States { START, PLAYERCHOICE, PLAYERMOVE, ENEMYCHOICE, ENEMYMOVE }
    States state;
    bool ranOnce = false;
    double flashTimer = 0.0;

    public EnemyChooser enemyChooser;

    Enemy e;

	// Use this for initialization
	void Start () {
        state = States.START;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.N)) {
            state = (States)((int)state + 1);
            if ((int)state > 4) {
                state = States.START;
            }
        }

        print("Current battle state: " + state);
        flashTimer = Mathf.PingPong(Time.time * 2, 1);

        if (ranOnce) {
            int attackNum = GetAttack();
            if (attackNum == 1) {
                if (flashTimer >= 0.9) {
                    enemyChooser.enemyStat.text = "<color=red>Attack 1: " + e.Attack1Title + "\n" +
                                                  "Damage: " + e.Attack1Damage + "</color>\n" +
                                                  "Attack 2: " + e.Attack2Title + "\n" +
                                                  "Damage: " + e.Attack2Damage;
                }
                if (flashTimer <= 0.1) {
                    enemyChooser.enemyStat.text = "Attack 1: " + e.Attack1Title + "\n" +
                                                  "Damage: " + e.Attack1Damage + "\n" +
                                                  "Attack 2: " + e.Attack2Title + "\n" +
                                                  "Damage: " + e.Attack2Damage;
                }
            }
            if (attackNum == 2) {
                if (flashTimer >= 0.9) {
                    enemyChooser.enemyStat.text = "Attack 1: " + e.Attack1Title + "\n" +
                                                  "Damage: " + e.Attack1Damage + "\n" +
                                                  "<color=red>Attack 2: " + e.Attack2Title + "\n" +
                                                  "Damage: " + e.Attack2Damage + "</color>";
                }
                if (flashTimer <= 0.1) {
                    enemyChooser.enemyStat.text = "Attack 1: " + e.Attack1Title + "\n" +
                                                  "Damage: " + e.Attack1Damage + "\n" +
                                                  "Attack 2: " + e.Attack2Title + "\n" +
                                                  "Damage: " + e.Attack2Damage;
                }
            }
        }
    }

    int GetAttack() {
        int attackNum = 1;
        int attackDam = e.Attack1Damage;
        if (e.Attack2Damage > attackDam) { attackDam = e.Attack2Damage; attackNum = 2; }
        if (e.Attack3Damage > attackDam) { attackNum = 3; }

        return attackNum;
    }

    void LateUpdate() {
        if (!ranOnce) {
            e = enemyChooser.currentEnemy.linkedEnemy;
            ranOnce = true;
        }
    }
}
