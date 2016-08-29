using UnityEngine;
using System.Collections;

public class levelgenerator2 : MonoBehaviour {

    public GameObject[] piece;
    public GameObject StartPiece;
    public GameObject EndPiece;
    public bool isLevelLoaded = false;
    int rand1;
    int rand2;
    int rand3;
    int rand4;
    int rand5;
    int rand6;
    int rand7;
    int rand8;
    int rand9;
    int rand10;
    void Start () {
        rand1 = Random.Range(0, piece.Length);
        rand2 = Random.Range(0, piece.Length);
        rand3 = Random.Range(0, piece.Length);
        rand4 = Random.Range(0, piece.Length);
        rand5 = Random.Range(0, piece.Length);
        rand6 = Random.Range(0, piece.Length);
        rand7 = Random.Range(0, piece.Length);
        rand8 = Random.Range(0, piece.Length);
        rand9 = Random.Range(0, piece.Length);
        rand10 = Random.Range(0, piece.Length);
        Instantiate(StartPiece, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(piece[rand2], new Vector3(20, 0, 0), Quaternion.identity);
        Instantiate(piece[rand3], new Vector3(40, 0, 0), Quaternion.identity);
        Instantiate(piece[rand4], new Vector3(60, 0, 0), Quaternion.identity);
        Instantiate(piece[rand5], new Vector3(80, 0, 0), Quaternion.identity);
        Instantiate(piece[rand6], new Vector3(100, 0, 0), Quaternion.identity);
        Instantiate(piece[rand7], new Vector3(120, 0, 0), Quaternion.identity);
        Instantiate(piece[rand8], new Vector3(140, 0, 0), Quaternion.identity);
        Instantiate(piece[rand9], new Vector3(160, 0, 0), Quaternion.identity);
        Instantiate(EndPiece, new Vector3(180, 0, 0), Quaternion.identity);
        isLevelLoaded = true;
    }
}
