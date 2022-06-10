using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField]  private TMP_Text timerText;
    private float timeElapsed;
    private int min,seg,cent;

    void Update()
    {

        timeElapsed += Time.deltaTime;
        min = (int)(timeElapsed / 60f);
        seg  = (int)(timeElapsed - min * 60f);
        cent = (int)((timeElapsed - (int)timeElapsed) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}",min,seg,cent);
    }
}
