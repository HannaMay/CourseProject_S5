using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiCrystalls : MonoBehaviour {
    
    public Text crystText;
    public Text endText;
    public Text pauseText;

    void Update () {
        crystText.text = this.GetComponent<Movie>().crystalls.ToString();
        endText.text = this.GetComponent<Movie>().crystalls.ToString();
        pauseText.text = this.GetComponent<Movie>().crystalls.ToString();
    }
}
