using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BestTime : MonoBehaviour {

	// Use this for initialization
	public GameObject MinuteDisPlay;
	public GameObject SecondDisPlay;
	public GameObject MilliDisPlay;

	public float PrevTime;
	public float ThisTime;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter()
	{
		PrevTime = LapCompleteManage.PrevMinuteCount*1000 + LapCompleteManage.PrevSecondCount*10 + LapCompleteManage.PrevMilliCount;
		ThisTime = LapTimeManage.MinuteCount*1000 + LapTimeManage.SecondCount*10 + LapTimeManage.MilliCount;
		
		if (LapCompleteManage.count > 2) {
			if (PrevTime >= ThisTime) {

				LapCompleteManage.PrevMinuteCount = LapTimeManage.MinuteCount;
				LapCompleteManage.PrevSecondCount = LapTimeManage.SecondCount;
				LapCompleteManage.PrevMilliCount = LapTimeManage.MilliCount;
				if (LapTimeManage.SecondCount <= 9) {
					SecondDisPlay.GetComponent<Text> ().text = "0" + LapTimeManage.SecondCount + ". ";
				} else {
					SecondDisPlay.GetComponent<Text> ().text = "" + LapTimeManage.SecondCount + ". ";
				}

				if (LapTimeManage.MinuteCount <= 9) {
					MinuteDisPlay.GetComponent<Text> ().text = "0" + LapTimeManage.MinuteCount + ": ";
				} else {
					MinuteDisPlay.GetComponent<Text> ().text = "" + LapTimeManage.MinuteCount + ": ";
				}
				MilliDisPlay.GetComponent<Text> ().text = "" + LapTimeManage.MilliCount;
			}
		} else {
			if (LapCompleteManage.PrevSecondCount <= 9) {
					SecondDisPlay.GetComponent<Text> ().text = "0" + LapCompleteManage.PrevSecondCount + ". ";
				} else {
					SecondDisPlay.GetComponent<Text> ().text = "" + LapCompleteManage.PrevSecondCount + ". ";
				}

			if (LapCompleteManage.PrevMinuteCount <= 9) {
					MinuteDisPlay.GetComponent<Text> ().text = "0" + LapCompleteManage.PrevMinuteCount + ": ";
				} else {
					MinuteDisPlay.GetComponent<Text> ().text = "" + LapCompleteManage.PrevMinuteCount + ": ";
				}
				MilliDisPlay.GetComponent<Text> ().text = "" + LapCompleteManage.PrevMilliCount;
		}

		LapTimeManage.SecondCount = 0;
		LapTimeManage.MinuteCount = 0;
		LapTimeManage.MilliCount = 0;
	}
}
