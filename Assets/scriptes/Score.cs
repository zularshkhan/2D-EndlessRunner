using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    private float score;

    private void Start()
    {
        score = 0f;
    }
    private void Update()
    {
        score += 1 * Time.deltaTime;
        text.text = ((int)score).ToString();
    }
}
