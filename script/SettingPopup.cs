using System.Collections;
using UnityEngine;

public class SettingPopup : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(true);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
    public void OnSubmitName(string name)
    {
        Debug.Log("name");
    }
    public void OnSpeedValue(float speed)
    {
        Debug.Log("Speed"+ speed);
    }
   /* public void OnSoundValue(float volume)
    {
        Manager.Audio.soundVolume=volume;
    }*/
}
