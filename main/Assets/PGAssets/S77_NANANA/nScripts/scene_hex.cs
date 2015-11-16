using UnityEngine;
using System.Collections;

public class scene_hex : MonoBehaviour 
{
    
    public GameObject groundParent;
    public HexBase hexBase;


	void Start () 
    {
        for (int i = 0; i < 4; ++i )
        {
            _createGround(HexCoord.ORIGINAL * i, 0.38f);
            _createGround(HexCoord.TOP_LEFT * i, 0.38f);
            _createGround(HexCoord.TOP_MIDDLE * i, 0.38f);
            _createGround(HexCoord.TOP_RIGHT * i, 0.38f);
            _createGround(HexCoord.BOTTOM_LEFT * i, 0.38f);
            _createGround(HexCoord.BOTTOM_MIDDLE * i, 0.38f);
            _createGround(HexCoord.BOTTOM_RIGHT * i, 0.38f);
        }

            
	}
    
    private void _createGround(HexCoord coord, float radius)
    {
        HexBase _base = Instantiate(hexBase).GetComponent<HexBase>();

        _base.create(coord, radius);
        _base.transform.parent = groundParent.transform;
        _base.transform.localPosition = _base.getTranslation();
    }
	

}
