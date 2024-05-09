using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private GameObject EventPanelUserInRange;
    [SerializeField] private GameObject EventPanelUserNotInRange;
    [SerializeField] private GameObject EventPanelUserInfo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayEventMenuInRange()
    {
        EventPanelUserInRange.SetActive(true);
    }

    public void DisplayEventMenuNotInRange()
    {
        EventPanelUserNotInRange.SetActive(true);
    }

    public void CloseButtonClick()
    {
        EventPanelUserNotInRange.SetActive(false);
        EventPanelUserInRange.SetActive(false);
    }

    public void InfoCloseButton()
    {
        EventPanelUserInRange.SetActive(true);
        EventPanelUserInfo.SetActive(false);
    }

    public void InfoButtonClick()
    {
        EventPanelUserInfo.SetActive(true);
        EventPanelUserInRange.SetActive(false);
    }
}
