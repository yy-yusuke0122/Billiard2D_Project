using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlideController : MonoBehaviour, IDragHandler
{
    public RectTransform m_rectTransform = null;

    public void OnDrag(PointerEventData eventData)
    {
        m_rectTransform.position += new Vector3(eventData.delta.x * 1.0f, 0f, 0f);
    }

    public void Update()
    {
        if (m_rectTransform.position.x > 150)
        {
            m_rectTransform.position -= new Vector3(20.0f, 0f, 0f);
        }
    }   
}
