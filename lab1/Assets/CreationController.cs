using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreationController : MonoBehaviour
{
    [SerializeField] InputField Input;
    [SerializeField] GameObject Cube;
    private List<GameObject> created = new List<GameObject>();
    public void CreateCubes()
    {
        foreach(var el in created)
            Destroy(el);
        var amount = 0;
        int.TryParse(Input.text, out amount);
        if (amount > 10)
        {
            Input.text = "lol, ne";
            return;
        }

        for (int i = 0; i < amount; ++i)
            created.Add(Instantiate(Cube, new Vector3(-0.35f, -0.311f + i, -4.59f), Quaternion.identity));
    }
}
