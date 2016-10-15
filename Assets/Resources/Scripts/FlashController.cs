using UnityEngine;
using Vuforia;
using System.Collections;

public class FlashController : MonoBehaviour {

	private bool canActive;

	void Start() {
		canActive = true;
	}

	public void FlashBehaviour() {
		if (canActive) {
			CameraDevice.Instance.SetFlashTorchMode (true);
			canActive = false;
		} else {
			CameraDevice.Instance.SetFlashTorchMode (false);
			canActive = true;
		}
	}

	public void Focus() {
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
	}
}
