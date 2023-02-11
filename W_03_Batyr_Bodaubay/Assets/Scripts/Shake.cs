using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public bool start = false;
    [SerializeField] AnimationCurve ac;
    [SerializeField] float _duration = 0.7f;

    // Update is called once per frame
    void Update()
    {
        if(start){
            start = false;
            StartCoroutine(ShakeEff());
        }
    }

    IEnumerator ShakeEff(){
        Vector3 startPos = transform.position;
        float elapsedT = 0f;

        while(elapsedT < _duration){
            elapsedT += Time.deltaTime;
            float shkFactor = ac.Evaluate(elapsedT/_duration);
            transform.position = startPos + UnityEngine.Random.insideUnitSphere*shkFactor;
            yield return null;
        }
    }
}
