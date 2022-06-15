using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsButton : MonoBehaviour
{
    public ads ads1;
    public GameObject buttonAds;
    // Start is called before the first frame update
    void Start()
    {
       // buttonAds.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdsButon()
    {
        ads1.CallAds();
        Debug.Log("run ads");
        buttonAds.SetActive(false);
        
        
    }
}
