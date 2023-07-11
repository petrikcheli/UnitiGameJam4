using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    public Transform Hex;
    public Transform Player;
    HexCoordinates nextGame;

    // Start is called before the first frame update
    void Start()
    {
        Hex = GetComponent<Transform>();
        nextGame = HexCoordinates.FromPosition(transform.InverseTransformPoint(Hex.position));
    }

    // Update is called once per frame
    void Update()
    {
        HexCoordinates coordinates = HexCoordinates.FromPosition(transform.InverseTransformPoint(Player.position));
        if (nextGame.X == coordinates.X && nextGame.Z == coordinates.Z && nextGame.Y == coordinates.Y)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
