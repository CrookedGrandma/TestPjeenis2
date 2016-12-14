using UnityEngine;
using System.Collections;

public class PressurePlate : MonoBehaviour {

    public string FightAgainst = "";

	void OnCollisionEnter() {
        if (FightAgainst != "") {
            ThirdPersonController.player.Enemy = FightAgainst;
        }
    }
}
