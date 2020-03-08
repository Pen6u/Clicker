using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour {
    private void Update () {
        transform.localScale = Vector3.Lerp (transform.localScale, transform.localScale * -2, Time.deltaTime / 20);

        if (transform.localScale.x <= 0.25) {
            Destroy (gameObject);
            Score.Count--;
        }
    }
}