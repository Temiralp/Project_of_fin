﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.Advertisements;

public class Menu_Gameover : MonoBehaviour {
    public Text attemptTxt;
   public ads ads1;
    void OnEnable() {
        attemptTxt.text = "Attempt: " + GlobalValue.Attempt;
	}

    public void TryAgain()
    {
    //    ads1.CallAds();
        GameManager.Instance.ResetLevel();
    }
}
