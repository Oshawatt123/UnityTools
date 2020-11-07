using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/*
 * Place me inside Assets/Editor folder.
 * All your newly imported assets will have pixel setting
 * applied to them as below.
 */
public class PixelImport : AssetPostprocessor
{
    private void OnPostprocessTexture(Texture2D texture)
    {
        TextureImporter textureImporter = (TextureImporter) assetImporter;
        textureImporter.textureType = TextureImporterType.Sprite;
        textureImporter.filterMode = FilterMode.Point;
        textureImporter.textureShape = TextureImporterShape.Texture2D;
        textureImporter.textureCompression = TextureImporterCompression.Uncompressed;
    }
}
