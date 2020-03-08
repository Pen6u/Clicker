using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static int Count;
    public static bool Dead;
    private Text Amount;

    void Start () {
        Count = 0;
        Dead = false;
        Amount = GetComponent<Text> ();
    }

    void Update () {
        if ((Count >= 0) && (!Dead))
            Amount.text = "Score: " + Count;
        else {
            Amount.text = "You lost";
            Time.timeScale = 0;
            Dead = true;
        }
    }
}