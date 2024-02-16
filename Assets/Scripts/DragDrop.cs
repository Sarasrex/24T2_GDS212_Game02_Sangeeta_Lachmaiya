using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("test01");
    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
        Debug.Log("test02");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
        Debug.Log("test03");
    }
}
