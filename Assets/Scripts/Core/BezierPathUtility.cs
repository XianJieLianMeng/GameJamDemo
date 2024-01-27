using UnityEngine;

public static class BezierPathUtility
{
    // 计算贝塞尔曲线上的点
    public static Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        // B(t) = (1-t)^2 * P0 + 2(1-t)t * P1 + t^2 * P2
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        float uuu = uu * u;
        float ttt = tt * t;

        Vector3 p = uuu * p0;
        p += 2 * uu * t * p1;
        p += tt * p2;

        return p;
    }

    // 计算贝塞尔曲线上的路径点数组
    public static Vector3[] CalculateBezierPath(int resolution, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        Vector3[] path = new Vector3[resolution + 1];

        for (int i = 0; i <= resolution; i++)
        {
            float tNormalized = i / (float)resolution;
            path[i] = CalculateBezierPoint(tNormalized, p0, p1, p2);
        }

        return path;
    }
}
