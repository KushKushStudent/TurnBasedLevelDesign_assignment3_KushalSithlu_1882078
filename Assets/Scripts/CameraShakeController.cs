using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeController : MonoBehaviour
{
    // Start is called before the first frame update
    public IEnumerator Shake(float duration, float magnitude) 
    {
        Vector3 originalCamPos = transform.localPosition;
        float elapsed = 0.0f;
        while (elapsed<duration) 
        {
            float x = Random.Range(-1, 1f) * magnitude;
            float y = Random.Range(-1, 1f) * magnitude;
            transform.localPosition = new Vector3(x, y, originalCamPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        
        }
        transform.localPosition = originalCamPos;
    
    }
}
