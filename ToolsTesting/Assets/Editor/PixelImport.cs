using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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
