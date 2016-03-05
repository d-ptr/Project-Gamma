using UnityEngine;
using UnityEditor;
using System.Collections;

public class SceneBuilder : EditorWindow
{
    [MenuItem("PGEditors/Scene Builder")]
    static void Open()
    {
        SceneBuilder _builder = (SceneBuilder)EditorWindow.GetWindow(typeof(SceneBuilder));
        _builder.Show();
    }

    /*
    void OnGUI()
    {
        if (GUILayout.Button("abc"))
        {
            var _hexBaseArr = GameObject.FindObjectsOfType<HexBase>();
            Debug.Log(_hexBaseArr.Length);
            _mergeMesh(_hexBaseArr);
        }
    }


    private void _mergeMesh(HexBase[] hexBaseArr)
    {
        MeshFilter[] _meshFilters = new MeshFilter[hexBaseArr.Length];

        for ( int i = 0 ; i < hexBaseArr.Length ; ++i )
        {
            _meshFilters[i] = hexBaseArr[i].GetComponent<MeshFilter>();
        }

        CombineInstance[] _combine = new CombineInstance[_meshFilters.Length];
        for ( int i = 0 ; i < _meshFilters.Length ; ++i )
        {
            _combine[i].mesh = _meshFilters[i].sharedMesh;
            _combine[i].transform = _meshFilters[i].transform.localToWorldMatrix;
        }

        Mesh _mesh = new Mesh();

        _mesh.CombineMeshes(_combine);

        AssetDatabase.CreateAsset(_mesh, "Assets/mesh.asset");
        AssetDatabase.SaveAssets();
    }
    */
}
