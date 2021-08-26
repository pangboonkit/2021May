using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]  
    private SettingPopup settingPopup;
    [SerializeField]
    private Text scoreLabel;
    void Start()
    {
        settingPopup.Close();
    }
    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }
    public void OnOpenSetting()
    { Debug.Log("open:");
        settingPopup.Open();
       
    }
/*    public void OnPointerDown()
    {
        Debug.Log("pointer down");
    }
 * */
}
