using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalConverter : MonoBehaviour {

	[SerializeField]
	private Text mValue;
	[SerializeField]
	private Text currency;

	private float cValue;
	private bool convertBase;

	void Start() {
		convertBase = false;
		cValue = 0;
	}

	public void changeCurrency() {
		if (!convertBase) {
			currency.text = "USD";
			float tmp = float.Parse (mValue.text);
			Debug.Log (tmp);
			tmp *= 0.31f;
			tmp = convertToMoney (tmp);
			mValue.text = tmp.ToString ();
			convertBase = true;
		} else {
			currency.text = "BRL";
			float tmp = float.Parse (mValue.text);
			Debug.Log (tmp);
			tmp *= 3.2f;
			tmp = convertToMoney (tmp);
			mValue.text = tmp.ToString ();
			convertBase = false;
		}
	}

	public float convertToMoney(float f) {
		return Mathf.Floor(f * 100) / 100;
	}

	public void AddValue(float value) {
		cValue += value;
		mValue.text = cValue.ToString ();
	}

	/*public void RemoveValue(float value) {
		cValue -= value;
		mValue.text = cValue.ToString ();
	}*/
}
