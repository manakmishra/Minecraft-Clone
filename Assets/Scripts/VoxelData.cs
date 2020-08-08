﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VoxelData
{

    public static readonly int chunkWidth = 16;
    public static readonly int chunkHeight = 128;
    public static readonly int worldSizeInChunks = 100;
    public static int worldSizeInVoxels {

        get { return worldSizeInChunks * chunkWidth; }
    } 

    public static readonly int viewDistanceInChunks = 8;

    public static readonly int textureAtlasSizeInBlocks = 16;
    
    public static float NormalizedBlockTextureSize {

        get{return 1f /(float)textureAtlasSizeInBlocks;}
    }

    public static readonly Vector3[] voxelVert = new Vector3[8] {
        
        new Vector3(0.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 1.0f, 1.0f),
        new Vector3(0.0f, 1.0f, 1.0f),
    };

    public static readonly Vector3[] adjFaceChecks = new Vector3[6] {

        new Vector3(0.0f, 0.0f, -1.0f), //backFace
        new Vector3(0.0f, 0.0f, 1.0f), //frontFace
        new Vector3(0.0f, 1.0f, 0.0f), //topFace
        new Vector3(0.0f, -1.0f, 0.0f), //bottomFace
        new Vector3(-1.0f, 0.0f, 0.0f), //leftFace
        new Vector3(1.0f, 0.0f, 0.0f), //rightFace
    };

    public static readonly int[,] voxelTriangles = new int[6, 4] {

        {0, 3, 1, 2}, //backFace
        {5, 6, 4, 7}, //frontFace
        {3, 7, 2, 6}, //topFace
        {1, 5, 0, 4}, //bottomFace
        {4, 7, 0, 3}, //leftFace
        {1, 2, 5, 6}, //rightFace  
    };

    public static readonly Vector2[] voxeluvs = new Vector2[4] {
        
        new Vector2(0.0f, 0.0f),
        new Vector2(0.0f, 1.0f),
        new Vector2(1.0f, 0.0f),
        new Vector2(1.0f, 1.0f),
    };

}
