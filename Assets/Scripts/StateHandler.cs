using UnityEngine;
using System.Collections;

public class StateHandler : MonoBehaviour {

    enum States { START, PLAYERCHOICE, PLAYERMOVE, ENEMYCHOICE, ENEMYMOVE }
    States state;

	// Use this for initialization
	void Start () {
        state = States.START;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.N)) {
            state = (States)((int)state + 1);
        }
        print(state);
	}
}
