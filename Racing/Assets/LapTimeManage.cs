using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapTimeManage : MonoBehaviour {


	public static int MinuteCount;
	public static int SecondCount;
	public static float MilliCount;
	public static string MilliDisplay;
	public static float LapTime;
	public GameObject MinuteBox;
	public GameObject SecondBox;
	public GameObject MilliBox;


	// Update is called once per frame
	void Update () {
		
			MilliCount += Time.deltaTime * 10;
			LapTime += Time.deltaTime * 10;
			MilliDisplay = MilliCount.ToString ("F0");
			MilliBox.GetComponent<Text> ().text = "" + MilliDisplay;

			if (MilliCount >= 10) {
				MilliCount = 0;
				SecondCount++;
			}

			if (SecondCount <= 9) {
				SecondBox.GetComponent<Text> ().text = "0" + SecondCount + ".";
			} else {
				SecondBox.GetComponent<Text> ().text = "" + SecondCount + ".";
			}

			if (SecondCount > 59) {
				MinuteCount++;
				SecondCount = 0;
			}
			if (MinuteCount <= 9) {
				MinuteBox.GetComponent<Text> ().text = "0" + MinuteCount + ":";
			} else {
				MinuteBox.GetComponent<Text> ().text = "" + MinuteCount + ":";
			}
		}
	
}
