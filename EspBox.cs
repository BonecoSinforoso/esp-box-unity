using UnityEngine;

public class EspBox : MonoBehaviour
{
    [SerializeField] GameObject[] go;
    [SerializeField] RectTransform[] rect;
    
    void Update()
    {
        for (int i = 0; i < go.Length; i++)
        {
            Vector3 _goPos = Camera.main.WorldToScreenPoint(go[i].transform.position);
            Vector3 _canvasPos;
            RectTransformUtility.ScreenPointToWorldPointInRectangle(rect[i], _goPos, null, out _canvasPos);
            rect[i].localPosition = _canvasPos - new Vector3(Screen.width / 2, Screen.height / 2);
        }
    }
}
