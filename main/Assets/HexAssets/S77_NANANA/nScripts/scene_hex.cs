using UnityEngine;
using System.Collections;

using Hex;


public class scene_hex : MonoBehaviour 
{

    public GameObject hexBoardPf;

    public float radius;

    public int groundSize;


	void Start () 
    {
        _createGround();
    }



	private void _createGround()
    {
        _createBoard(0, 0, 0);


        for ( int i =  -groundSize; i < groundSize; i++)
        {
            for ( int j = -groundSize; j < groundSize; j++)
            {
                _createBoard(i, j, 0);
            }
        }
    }

    private void _createBoard(int a, int g, int r)
    {
        var _gb = Instantiate(hexBoardPf) as GameObject;
        _gb.transform.parent = transform;
        _gb.transform.localPosition = new HexVtr3(a, g, r).catesianCoord() * radius;
    }


}
