using UnityEngine;
using System.Collections;

public class HalfFinish : MonoBehaviour {

	public GameObject LapCompleteTrigger;
	public GameObject HalfLapTrigger;

	void OnTriggerEnter()
	{
		LapCompleteTrigger.SetActive (true);
		HalfLapTrigger.SetActive (false);
	}
}
