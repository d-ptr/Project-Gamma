using UnityEngine;
using System.Collections;

// --------------------------------------------------------------------
// Introduction
// 
//           ---------------
//          /               \
//         /                 \
//        /                   \             r = radius of hexgon
//       /               r     \            h = line from center prepeticalur to the edge
//                  ------------
//       \           \    v 90°/
//        \           ------- /
//         \            h    /
//          \               /
//           ---------------
// --------------------------------------------------------------------
public class HexBase : MonoBehaviour 
{
    // -------------------------------- Member Property -------------------------------- //
    /// <summary>
    /// return the Coordinates of the base in system.
    /// </summary>
    public HexCoord Coord
    {
        get { return _mCoord; }
    }

    /// <summary>
    /// get the radius of the hexagon. Read only
    /// </summary>
    public float Radius
    {
        get { return _mRadius; }
    }

    /// <summary>
    /// get the line from center prepeticalur to the edge. Read only
    /// </summary>
    public float Height
    {
        get { return _mHeight; }
    }

    // -------------------------------- Internal Member -------------------------------- //

    /// <summary>
    /// Hex Coordinate of this base in the hex system 
    /// </summary>
    private HexCoord _mCoord;

    /// <summary>
    /// Radius of the base
    /// </summary>
    private float _mRadius = 0f;

    /// <summary>
    /// line from center prepeticalur to the edge
    /// </summary>
    private float _mHeight = 0f;

    // -------------------------------- Life Cycle -------------------------------- //
	

    // -------------------------------- Funciton part -------------------------------- //

    /// <summary>
    /// You can only active this base by create it
    /// </summary>
    /// <param name="coord"></param>
    public void create(HexCoord coord, float radius)
    {
        _mCoord = coord;
        _mRadius = radius;
    }
	
    public Vector3 getTranslation()
    {
        Vector2 _pos = _mCoord.CartesianCoord * _mRadius;
        return new Vector3(_pos.x, 0, _pos.y);
    }

}
