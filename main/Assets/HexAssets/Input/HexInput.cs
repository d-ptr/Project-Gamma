using UnityEngine;
using System.Collections;

namespace Hex
{

    public static class HexInput
    {
        public static bool MoveFront()
        {
            return Input.GetKeyDown(KeyCode.W);
        }

        public static bool MoveBack()
        {
            return Input.GetKeyDown(KeyCode.S);
        }

        public static bool MoveLeftUp()
        {
            return Input.GetKeyDown(KeyCode.Q);
        }

        public static bool MoveLeftDown()
        {
            return Input.GetKeyDown(KeyCode.A);
        }

        public static bool MoveRightUp()
        {
            return Input.GetKeyDown(KeyCode.E);
        }

        public static bool MoveRightDown()
        {
            return Input.GetKeyDown(KeyCode.D);
        }

    }

}