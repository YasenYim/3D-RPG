using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethod 
{
    private const float dotThreshold = 0.5f; // dotThteshold��һ������

    public static bool IsFacingTarget(this Transform transform,Transform target) // this�ǹؼ��֣�this������ľ�����չ��Ӧ���࣬����֮����ǵ��õı���
    {
        var vectorToTarget = target.position - transform.position;
        vectorToTarget.Normalize();

        float dot = Vector3.Dot(transform.forward, vectorToTarget);

        return dot >= dotThreshold;
        
    }
}
