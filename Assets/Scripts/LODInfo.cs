using System;
using UnityEngine;

[Serializable]
public struct LODInfo
{
    [Range(0, MeshSettings.NUM_SUPPORTED_LODS - 1)]
    public int LOD;
    public float VisibleDstThreshold;
    public float SqrVisibleDstThreshold => VisibleDstThreshold * VisibleDstThreshold;
}