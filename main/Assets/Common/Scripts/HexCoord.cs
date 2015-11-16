#if UNITY_EDITOR
#define PRINT_DEBUG
#endif

using UnityEngine;
using System.Collections;


// --------------------------------------------------------------------
// Introduction
// This is a class to control hex coordinate system.
// Suppose h is the hexagon, the coordination system will like this
//      
//           ----
//          /    \
//      ----  h6  ----              where 
//     /    \    /    \
//       h2  ----  h4               h1 = ( 0, 0)
//     \    /    \    /             h2 = (-1, 1)
//      ----  h1  ----              h3 = (-1,-1)
//     /    \    /    \             h4 = ( 1, 1)
//       h3  ----  h5               h5 = ( 1,-1)
//     \    /    \    /             h6 = ( 0, 2)
//      ----  h7  ----              h7 = ( 0, -2)
//          \    /
//           ----
//
// --------------------------------------------------------------------
//  Propert for (xh,yh)
//  1.  xh+yh must be a even number
//  2.  xh and yh can't be a decimal number
// --------------------------------------------------------------------
//
//  Naming
//  --coord
//      xh = x in hex corrdinates
//      yh = y in hex coordinates
//      xc = x in cartesian coordinates
//      yc = x in cartesian coordiantes
//
//  --position
//      position of h2 from h1 is TOP_LEFT
//      position of h6 from h1 is TOP_MIDDLE
//      position of h4 from h1 is TOP_RIGHT
//      position of h3 from h1 is BOTTOM_LEFT
//      position of h7 from h1 is BOTTOM_MIDDLE
//      position of h5 from h1 is BOTTOM_RIGHT
// --------------------------------------------------------------------

public class HexCoord
{
    // -------------------------------- Constant -------------------------------- // 
    /// <summary>
    /// xc = HTD_CONST_X * xh;
    /// </summary>
    private const float HTD_CONST_X = 1.5f;

    /// <summary>
    ///  yc = HTD_CONST_Y * yh;
    /// </summary>
    private const float HTD_CONST_Y = 0.866f;

    // -------------------------------- Static Property -------------------------------- //
    
    /// <summary>
    /// create TOP_LEFT poistion
    /// </summary>
    public static HexCoord TOP_LEFT { get { return new HexCoord(-1,1); } }

    /// <summary>
    /// create TOP_LEFT poistion
    /// </summary>
    public static HexCoord TOP_MIDDLE { get { return new HexCoord(0, 2); } }

    /// <summary>
    /// create TOP_LEFT poistion
    /// </summary>
    public static HexCoord TOP_RIGHT { get { return new HexCoord(1, 1); } }

    /// <summary>
    /// create TOP_LEFT poistion
    /// </summary>
    public static HexCoord BOTTOM_LEFT { get { return new HexCoord(-1, -1); } }

    /// <summary>
    /// create TOP_LEFT poistion
    /// </summary>
    public static HexCoord BOTTOM_MIDDLE { get { return new HexCoord(0, -2); } }

    /// <summary>
    /// create TOP_LEFT poistion
    /// </summary>
    public static HexCoord BOTTOM_RIGHT { get { return new HexCoord(1, -1); } }

    /// <summary>
    /// create ORIGINAL poistion
    /// </summary>
    public static HexCoord ORIGINAL { get { return new HexCoord(0, 0); } }


    // -------------------------------- Member Property -------------------------------- //
    /// <summary>
    /// Get the x in hex coordiantes. Read only.
    /// </summary>
    public int Xh { get { return _mX; } }

    /// <summary>
    /// Get the y in hex coordiantes. Read only.
    /// </summary>
    public int Yh { get { return _mY; } }

    /// <summary>
    /// Get the x in cartesian coordiantes. Read only.
    /// </summary>
    public float Xc { get { return _mX * HTD_CONST_X; }}

    /// <summary>
    /// Get the x in cartesian coordiantes. Read only.
    /// </summary>
    public float Yc { get { return _mY * HTD_CONST_Y; } }

    /// <summary>
    /// Get the catersian coordniate from (xh, yh)
    /// </summary>
    public Vector2 CartesianCoord
    {
        get { return new Vector2(Xc, Yc); }
    }

    // -------------------------------- Internal Member -------------------------------- //
    private int _mX;
    private int _mY;

    // -------------------------------- Funciton part -------------------------------- //

    /// <summary>
    /// Construct a original hex coord
    /// </summary>
 
    public HexCoord()
    {
        _mY = _mX = 0;
    }

    /// <summary>
    /// Construct a hex coord by x and y
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public HexCoord(int x, int y)
    {
        _mX = x;
        _mY = y;

#if PRINT_DEBUG
        if ( !isValid()  )
        {
            Debug.LogError("This is not a valid hex coordinate.");
        }
#endif

    }

    public bool isValid()
    {
        return ((_mX + _mY) % 2 == 0);
    }

    // -------------------------------- Overloading  -------------------------------- //
    public static HexCoord operator *(HexCoord coord, int n)
    {
        return new HexCoord(coord._mX * n, coord._mY * n);
    }

}
