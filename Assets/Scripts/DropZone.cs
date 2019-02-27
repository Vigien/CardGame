using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using System;

namespace SA
{
    public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
        {

        }
        public void OnDrop(PointerEventData eventData)
        {
            Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
            if (d != null)
            {
                d.parentToReturnTo = this.transform;
            }
        }
        public void OnPointerExit(PointerEventData eventData)
        {

        }


    }
}