using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethod 
{
    private const float dotThreshold = 0.5f; // dotThteshold是一个常量

    public static bool IsFacingTarget(this Transform transform,Transform target) // this是关键字，this后面跟的就是拓展对应的类，逗号之后才是调用的变量
    {
        var vectorToTarget = target.position - transform.position;
        vectorToTarget.Normalize();

        float dot = Vector3.Dot(transform.forward, vectorToTarget);

        return dot >= dotThreshold;
        
    }
}
