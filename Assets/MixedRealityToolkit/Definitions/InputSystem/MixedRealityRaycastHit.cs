﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Input
{
    /// <summary>
    /// The resulting hit information from an IMixedRealityRaycastProvider.
    /// </summary>
    public struct MixedRealityRaycastHit
    {
        public Vector3 point;
        public Vector3 normal;
        public Vector3 barycentricCoordinate;
        public float distance;
        public int triangleIndex;
        public Vector2 textureCoord;
        public Vector2 textureCoord2;
        public Transform transform;
        public Vector2 lightmapCoord;
        public bool raycastValid;

        public MixedRealityRaycastHit(bool raycastValid, RaycastHit hitInfo)
        {
            this.raycastValid = raycastValid;
            if (raycastValid)
            {
                point = hitInfo.point;
                normal = hitInfo.normal;
                barycentricCoordinate = hitInfo.barycentricCoordinate;
                distance = hitInfo.distance;
                triangleIndex = hitInfo.triangleIndex;
                textureCoord = hitInfo.textureCoord;
                textureCoord2 = hitInfo.textureCoord2;
                transform = hitInfo.transform;
                lightmapCoord = hitInfo.lightmapCoord;
            }
            else
            {
                point = Vector3.zero;
                normal = Vector3.zero;
                barycentricCoordinate = Vector3.zero;
                distance = 0;
                triangleIndex = 0;
                textureCoord = Vector2.zero;
                textureCoord2 = Vector2.zero;
                transform = null;
                lightmapCoord = Vector2.zero;
            }
        }
    }
}
