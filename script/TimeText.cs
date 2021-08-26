using UnityEngine;
using UnityEngine.UI;

public class DroughtText: MonoBehaviour
{
    public Transform player;
    public Text droughttext;
    public bool playing;
    private float Timer;
     
    void Update()
    {
        if(playing==true)
        {
            Timer+=Time.deltaTime;
            int min=Mathf.FloorToInt(Timer/60f);
            int sec=Mathf.FloorToInt(Timer%60);
            droughttext.text = min.ToString("00") + ":" + sec.ToString("00");
        }
    }
}
