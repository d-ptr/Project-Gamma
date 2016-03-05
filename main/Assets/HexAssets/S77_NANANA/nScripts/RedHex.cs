using UnityEngine;
using System.Collections;

using Hex;

public class RedHex : MonoBehaviour
{
    public float slap;


	
	void Update ()
    {
	    if (HexInput.MoveFront())
        {
            transform.position += new HexVtr3(0, 1).catesianCoord() * slap;
        }

        if (HexInput.MoveBack())
        {
            transform.position += new HexVtr3(0, -1).catesianCoord() * slap;
        }

        if (HexInput.MoveLeftUp())
        {
            transform.position += new HexVtr3(-1, 0).catesianCoord() * slap;
        }

        if (HexInput.MoveLeftDown())
        {
            transform.position += new HexVtr3(-1, -1).catesianCoord() * slap;
        }

        if (HexInput.MoveRightUp())
        {
            transform.position += new HexVtr3(1, 1).catesianCoord() * slap;
        }

        if (HexInput.MoveRightDown())
        {
            transform.position += new HexVtr3(1, 0).catesianCoord() * slap;
        }
    }
}
