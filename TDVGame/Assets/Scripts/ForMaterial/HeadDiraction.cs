using UnityEngine;

public class HeadDiraction : MonoBehaviour
{
    [SerializeField]
    private Material _faceMaterial;

    private void Update()
    {
        if(_faceMaterial)
        {
            _faceMaterial.SetVector("_HeadForward", transform.forward);
            _faceMaterial.SetVector("_HeadRight", transform.right);
        }
    }
}
