using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_matrixTudo : MonoBehaviour
{
    //[SerializeField] GameObject obj_camera;
    [SerializeField] GameObject[] obj_cubo;
    //[SerializeField] GameObject obj_rect;
    [SerializeField] RectTransform[] rect;
    // Start is called before the first frame update
    void Start()
    {
        //rect = obj_rect.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //obj_rect.GetComponent<RectTransform>().localPosition = Camera.main.WorldToScreenPoint(new Vector2(obj_cubo.transform.position.x, obj_cubo.transform.position.y)) - new Vector3(Screen.width / 2, Screen.height / 2);
        //obj_rect.GetComponent<RectTransform>().localPosition = new Vector3(obj_rect.GetComponent<RectTransform>().localPosition.x, obj_rect.GetComponent<RectTransform>().localPosition.y, obj_cubo.transform.position.z * 100);

        for(int i = 0; i < obj_cubo.Length; i++)
        {
            Vector3 objectPos = Camera.main.WorldToScreenPoint(obj_cubo[i].transform.position); //isso vc ja usou
            Vector3 canvasPos; //vai receber valor embaixo
            RectTransformUtility.ScreenPointToWorldPointInRectangle(rect[i], objectPos, null, out canvasPos);
            rect[i].localPosition = canvasPos - new Vector3(Screen.width / 2, Screen.height / 2);
        }

        //obj_rect.GetComponent<RectTransform>().localPosition = new Vector3(100, 100, 0);
        //Vector2 dir = new Vector2(obj_cubo.transform.position.y, obj_cubo.transform.position.z) - new Vector2(obj_camera.transform.position.y, obj_camera.transform.position.z);
        //Vector2 dir2 = new Vector2(obj_cubo.transform.position.x, obj_cubo.transform.position.y) - new Vector2(obj_camera.transform.position.x, obj_camera.transform.position.y);
        //Vector2 dir3 = new Vector2(obj_cubo.transform.position.x, obj_cubo.transform.position.z) - new Vector2(obj_camera.transform.position.x, obj_camera.transform.position.z);
        //Vector2 dir = obj_cubo.transform.position - obj_camera.transform.position;
        //float ang = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //float ang2 = Mathf.Atan2(dir2.y, dir2.x) * Mathf.Rad2Deg;
        //float ang3 = Mathf.Atan2(dir3.y, dir3.x) * Mathf.Rad2Deg;

        //obj_camera.transform.rotation = Quaternion.AngleAxis(ang, Vector3.right);
        //obj_camera.transform.rotation = Quaternion.Euler(0, ang2, ang);
        //obj_camera.transform.rotation = Quaternion.Euler(0, 0, 0);
        //obj_camera.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}