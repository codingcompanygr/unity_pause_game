using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCheck : MonoBehaviour
{
    Pause pause;

    public GameObject pauseText;

    void Start()
    {
        pause = GameObject.FindGameObjectWithTag("PauseManager").GetComponent<Pause>();
    }

    void Update()
    {
        if (pause.isPaused)
        {
            pauseText.SetActive(true);
        }
        else
        {
            pauseText.SetActive(false);
        }
    }
}
