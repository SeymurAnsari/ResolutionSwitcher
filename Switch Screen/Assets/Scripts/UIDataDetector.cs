using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class UIDataDetector : MonoBehaviour
{
    [SerializeField] private GameObject dataText;

    private RectTransform rt;

    void Start()
    {

    }

    void Update()
    {
        CheckMouseRaycast();
    }

    private void CheckMouseRaycast()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current) { pointerId = -1, position = Input.mousePosition };
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);
        if (results.Count > 0)
        {
            foreach (RaycastResult raycastResult in results)
            {
               
                rt = raycastResult.gameObject.GetComponent<RectTransform>();

                dataText.GetComponent<Text>().text = rt.rect.size.ToString();

            }
        }
    }

}
