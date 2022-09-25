using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class ToggleControl : MonoBehaviour
{

    public bool toolTipActive = true;
    
    public void ToggleToolTip(GameObject toolTip)
    {
        toolTipActive = !toolTipActive;
        toolTip.SetActive(toolTipActive);
    }
}
