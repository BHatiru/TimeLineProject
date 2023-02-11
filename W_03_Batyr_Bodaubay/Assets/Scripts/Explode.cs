using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    [SerializeField] Shake shake;
    [SerializeField] int _cubeCells = 10;
    [SerializeField] float _delay = 100f;
    [SerializeField] float _force = 400f;
    [SerializeField] float _explRadius = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Generator", _delay);
    }

    void Generator()
    {
        for (int x = 0; x < _cubeCells; x++)
        {
            for (int y = 0; y < _cubeCells; y++)
            {
                for (int z = 0; z < _cubeCells; z++)
                {
                    PlaceCube(new Vector3(x, y, z));
                }
            }
        }
        Destroy(gameObject);
        shake.start = true;
    }

    void PlaceCube(Vector3 pos)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        Renderer rd = cube.GetComponent<Renderer>();
        rd.material = GetComponent<Renderer>().material;

        cube.transform.localScale = transform.localScale / _cubeCells;
        Vector3 strCube = transform.position - transform.localScale/2 + cube.transform.localScale/2;
        cube.transform.position = strCube + Vector3.Scale(pos, cube.transform.localScale);

        Rigidbody rb = cube.AddComponent<Rigidbody>();
        rb.AddExplosionForce(_force, transform.position, _explRadius);
    }

}
