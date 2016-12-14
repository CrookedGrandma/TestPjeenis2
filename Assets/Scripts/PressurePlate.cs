using UnityEngine;
using System.Collections;

public class PressurePlate : MonoBehaviour {

    public int FightAgainst = -1;

	void OnCollisionEnter() {
        if (FightAgainst != -1) {
            ThirdPersonController.player.Enemy = FightAgainst;
        }
    }
}
