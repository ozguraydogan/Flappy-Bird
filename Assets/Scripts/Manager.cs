using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject pipe;
    private int scor = 0;
    public Text scor_txt;
    void Start()
    {
        InvokeRepeating("PipeAdd",0,7.0f);
        scor_txt.text = scor.ToString();
    }

    // Update is called once per frame
    void PipeAdd()
    {
        GameObject new_pipe = Instantiate(pipe);
    }

    public void ScorAdd(int add)
    {
        scor += add;
        scor_txt.text = scor.ToString();
    }
}
