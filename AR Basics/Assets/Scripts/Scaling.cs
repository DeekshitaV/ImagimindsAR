using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
	void onMouseDown()
    {
        CSharpscaling.ScaleTransform = this.transform;
    }
}
