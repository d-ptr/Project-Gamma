using UnityEngine;
using System.Collections;

public class scene_hex : MonoBehaviour 
{
    
    public GameObject groundParent;
    public GameObject ground;


	void Start () 
    {
        _createGround(HexCoord.ORIGINAL.CartesianCoord * 0.38f);
        _createGround(HexCoord.TOP_LEFT.CartesianCoord * 0.38f);
        _createGround(HexCoord.TOP_MIDDLE.CartesianCoord * 0.38f);
        _createGround(HexCoord.TOP_RIGHT.CartesianCoord * 0.38f);
        _createGround(HexCoord.BOTTOM_LEFT.CartesianCoord * 0.38f);
        _createGround(HexCoord.BOTTOM_MIDDLE.CartesianCoord * 0.38f);
        _createGround(HexCoord.BOTTOM_RIGHT.CartesianCoord * 0.38f);
	}
    
    private void _createGround(Vector2 pos)
    {
        GameObject _ground = Instantiate(ground);

        _ground.transform.parent = groundParent.transform;
        _ground.transform.localPosition = new Vector3(pos.x, 0, pos.y);
    }
	

}
