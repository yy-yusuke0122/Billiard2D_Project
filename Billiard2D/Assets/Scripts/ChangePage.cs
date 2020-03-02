using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePage : MonoBehaviour
{
    RectTransform rect;

    public ButtonLeft buttonLeft;
    public ButtonRight buttonRight;

    private bool L;
    private bool R;
    private int NowPage = 0;
    public int MaxPage;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        L = buttonLeft.buttonLeft;
        R = buttonRight.buttonRight;
        
        if (NowPage > 0)
        {
            if (L)
            {
                //ページを左
                rect.localPosition += new Vector3(800f, 0f, 0f);
                NowPage--;
                buttonLeft.buttonLeft = false;
            }
        }

        if (NowPage < MaxPage)
        {
            if (R)
            {
                //ページを右
                rect.localPosition += new Vector3(-800f, 0f, 0f);
                NowPage++;
                buttonRight.buttonRight = false;
            }

        }
    }
}
