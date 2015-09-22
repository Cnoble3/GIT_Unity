// Corey Noble
using UnityEngine;
using Assets.Code.States;

public class StateManager : MonoBehaviour {
	private BeginState activeState;
	void Start () {
		activeState = new BeginState();
		Debug.Log("This object is of the type: " + activeState);
	}
	void Update () {
	
	}
}
