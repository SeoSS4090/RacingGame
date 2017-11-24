using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapCompleteManage : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject LastMinuteBox;
	public GameObject LastSecondBox;
	public GameObject LastMilliBox;

	public GameObject Lap;
	public static int count;
	public static int PrevMinuteCount;
	public static int PrevSecondCount;
	public static float PrevMilliCount;

	void Start () {
		count = 1;
	}

	void OnTriggerEnter()
	{
		if (count == 1) {
			PrevSecondCount = LapTimeManage.SecondCount;
			PrevMinuteCount = LapTimeManage.MinuteCount;
			PrevMilliCount = LapTimeManage.MilliCount;
		}

		count++;
		Lap.GetComponent<Text>().text = count+"";

		//prev Lap Time 계산.

		if (LapTimeManage.SecondCount <= 9) {
			LastSecondBox.GetComponent<Text> ().text = "0" + LapTimeManage.SecondCount + ". ";
		} else {
			LastSecondBox.GetComponent<Text> ().text = "" + LapTimeManage.SecondCount + ". ";
		}

		if (LapTimeManage.MinuteCount <= 9) {
			LastMinuteBox.GetComponent<Text> ().text = "0" + LapTimeManage.MinuteCount + ": ";
		} else {
			LastMinuteBox.GetComponent<Text> ().text = "" + LapTimeManage.MinuteCount + ": ";
		}


		LastMilliBox.GetComponent<Text> ().text = "" + LapTimeManage.MilliCount;

		HalfLapTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);
	}
}
