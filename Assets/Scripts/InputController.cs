using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler 
{
    public static Vector2 Input;

    public void OnPointerDown(PointerEventData eventData)
    {
        Input = Vector2.zero;
        OnDrag(eventData); }
    public void OnDrag(PointerEventData eventData)
    {
        Input = eventData.pressPosition - eventData.position;
        Input = Input.normalized;
    } 
    public void OnPointerUp(PointerEventData eventData)
    {
        Input = Vector2.zero;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begin");
    }
}
