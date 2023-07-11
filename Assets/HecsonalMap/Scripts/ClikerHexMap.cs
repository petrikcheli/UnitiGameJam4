using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ClikerHexMap : MonoBehaviour
{
    HexCell cells;
    Mesh mesh;
    public Transform Player;
    private Camera cam1;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            HandleInput();
            Thread.Sleep(100);
        }
    }

    void HandleInput()
    {
        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(inputRay, out hit))
        {
            TouchCell(hit.point);
        }
    }

    void TouchCell(Vector3 position)
    {
        //position = transform.InverseTransformPoint(position);
        //HexCoordinates coordinates = new HexCoordinates(position.x, position.z);
        //Player.position = cells.Where(
         //   cell => cell != null && cell.coordinates.Equals(coordinates)); ;
        //Debug.Log("touched at " + coordinates.ToString());
    }
}

