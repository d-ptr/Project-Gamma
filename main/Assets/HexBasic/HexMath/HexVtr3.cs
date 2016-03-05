using UnityEngine;
using System.Collections;

//ref : http://jhnet.co.uk/articles/torus_paths

namespace Hex
{

    //             / ^   Guard  
    //            /   \
    //  relapse  v     \
    //          -------->Ambition


    // Key Word
    // Zeta                     :           第六個希臘字母, neta from 
    // Idel HexVtr              :           r = 0
    // Idealize                 :           keep same position and make r to be 0
    // CC                       :           Catesian coordinate

    // Remind
    // 1. default up axis in catesian coordiante is Y;

    public class HexVtr3
    {
        // **** Constant
        public const float HORIZ_ZETA = 1.5f;           //  1 + sin30
        public const float VERT_ZERA = 0.866025403f;    //  cos30


        // **** Property
        public int a
        {
            get { return _mA; }
            set { _mA = value; }
        }

        public int g
        {
            get { return _mG; }
            set { _mG = value; }
        }

        public int r
        {
            get { return _mR; }
            set { _mR = value; }
        }

        /// <summary>
        /// Catesian coordinate X
        /// </summary>
        public float x { get { return ( _mA - _mR) * HORIZ_ZETA; } }

        /// <summary>
        /// Catesian coordinate Y, Always 0
        /// </summary>
        public float y { get { return 0; } }

        /// <summary>
        /// Catesian coordiante Z
        /// </summary>
        public float z {  get { return (2 * _mG - _mR - _mA) * VERT_ZERA; } }



        public HexVtr3 Idealized
        {
            get
            {
                HexVtr3 _hVtr = new HexVtr3(this);
                _hVtr.idealize();
                return _hVtr;
            }
        }

       
        // **** Internal
        // ==> Hex Coordinate System
        private int _mA = 0;
        private int _mG = 0;
        private int _mR = 0;

        // **** Ctor

        public HexVtr3()
        {
            _mA = 0;
            _mG = 0;
            _mR = 0;
        }


        public HexVtr3(int a, int g, int r = 0)
        {
            _mA = a;
            _mG = g;
            _mR = r;
        }

        public HexVtr3(HexVtr3 hVtr)
        {
            _mA = hVtr._mA;
            _mG = hVtr._mG;
            _mR = hVtr._mR;
        }

        // **** Feacture

        public void idealize()
        {
            _mA -= _mR;
            _mG -= _mR;
            _mR = 0;
        }

        /// <summary>
        /// Benchmark = around 140 ns
        /// </summary>
        /// <returns>Catesian Coordinate In Vector3 form</returns>
        public Vector3 catesianCoord()
        {
            return new Vector3(x, y, z);
        }


        // **** Operator
        public static HexVtr3 operator +(HexVtr3 h1, HexVtr3 h2)
        {
            return new HexVtr3(h1.a + h2.a, h1.g + h2.g, h1.r + h2.r);
        }

        public static HexVtr3 operator -(HexVtr3 h1, HexVtr3 h2)
        {
            return new HexVtr3(h1.a - h2.a, h1.g - h2.g, h1.r - h2.r);
        }

        public static HexVtr3 operator *(HexVtr3 h, int n)
        {
            return new HexVtr3(h.a * n, h.g *n , h.r * n);
        }

        // **** Override

        public override string ToString()
        {
            return string.Format("HexVtr3{a:{0},g:{1},r:{2}", a, g, r);
        }


    }
}
