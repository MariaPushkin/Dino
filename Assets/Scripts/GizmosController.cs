using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshCollider))]

public class GizmosController : MonoBehaviour
{
    public string fishhame;
    public string dinoname;

    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 startPosition;  

    private GameObject dino;
    private GameObject fish;

    void Start()
    {
        dino = GameObject.Find(dinoname);
        fish = GameObject.Find(fishhame);
    }
    void Update()
    {
        //dino.transform.Rotate(0, 100 * Time.deltaTime, 0);
        //Debug.Log("This " + fish.transform.position.x);
    }

    void OnMouseDown()
    {
        startPosition = transform.position;

        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint); //&#43; offset;
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        double x1 = dino.transform.position.x + 0.1;
        double x2 = dino.transform.position.x - 0.1;
        double y1 = dino.transform.position.y + 0.321 + 0.5;
        double y2 = dino.transform.position.y + 0.321- 0.5;
        double z1 = dino.transform.position.z - 0.45 + 0.5;
        double z2 = dino.transform.position.z - 0.45 - 0.5;
        Debug.Log("x1 " + x1);
        Debug.Log("x2 " + x2);
        Debug.Log("This " + fish.transform.position.x);
        Vector3 fishpos = fish.transform.position;
        if (fishpos.x < x1 && fishpos.x > x2 && fishpos.y < y1 && fishpos.y > y2 && fishpos.z < z1 && fishpos.z > z2)
            gameObject.active = false;
            //gameObject.SetActive(false);
        else
        transform.position = startPosition;
    }
}
