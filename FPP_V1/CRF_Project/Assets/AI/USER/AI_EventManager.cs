using UnityEngine;
using System.Collections;

// 12/03/2016 created by Arnaud Mollé
// System de gestion d'event générale

public class AI_EventManager : MonoBehaviour {

	/* Collection de variable pour gérer la state
	// -1 = inactive
	// 0 =  onEnter
	// 1 = bypass onEnter
	*/
	private int nIdle = -1;

	// variables
	private float nTimer = 0;
	private string sCurrentState = "IDLE";
	
	void Start () {

		//Initialisation de la state
		nIdle = 0;
	}

	void e_Idle () {

		//onEnter
		if (nIdle == 0) {
			sCurrentState = "IDLE";
			nIdle = 1;
		}

		//onUpdate
		float dt = Time.deltaTime;
		nTimer += dt;

		//onLeave
		if ( nIdle == 2 || nTimer > 3){
			nTimer = 0;
			nIdle = -1;
		}

	}

	void Update () {

		if (nIdle >= 0) { this.e_Idle ();}
	}
}
