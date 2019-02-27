using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace SA
{
    public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        public Transform parentToReturnTo = null;
        GameObject placeholder = null;
        public void OnBeginDrag(PointerEventData eventData)
        {
            placeholder = new GameObject();
            placeholder.transform.SetParent(this.transform.parent);
            LayoutElement le = placeholder.AddComponent<LayoutElement>();
            le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
            le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
            le.flexibleWidth = 0;
            le.flexibleHeight = 0;

            placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
            parentToReturnTo = this.transform.parent;
            this.transform.SetParent(this.transform.parent.parent);
            gameObject.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        public void OnDrag(PointerEventData eventData)
        {
            this.transform.position = eventData.position;

            int newSiblingIndex = parentToReturnTo.childCount;
            for (int i = 0; i < parentToReturnTo.childCount; i++)
            {
                if (this.transform.position.x < parentToReturnTo.GetChild(i).position.x)
                {
                    newSiblingIndex = i;
                    if (placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                        newSiblingIndex--;
                    break;
                }
            }

            placeholder.transform.SetSiblingIndex(newSiblingIndex);
        }
        public void OnEndDrag(PointerEventData eventData)
        {
            gameObject.GetComponent<Image>().color = new Color32(255, 0, 0, 0);
            this.transform.SetParent(parentToReturnTo);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            Destroy(placeholder);
        }
    }
}