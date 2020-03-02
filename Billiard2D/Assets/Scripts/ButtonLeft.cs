using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeft : MonoBehaviour
{
    public bool buttonLeft = false;

    public void OnClick()
    {
        buttonLeft = true;
    }
}
