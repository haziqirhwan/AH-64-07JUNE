using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleFace : MonoBehaviour
{
    public GameObject model;

    private void Start()
    {
        DuplicateFaces();
    }
    public void DuplicateFaces()
    {
        for (int i = 0; i < model.GetComponentsInChildren<Renderer>().Length; i++) // Loop through the model children
        {
            // Get original mesh components: vertices, normals, triangles, and texture coordinates
            Mesh mesh = model.GetComponentsInChildren<MeshFilter>()[i].mesh;
            Vector3[] vertices = mesh.vertices;
            int numOfVertices = vertices.Length;
            Vector3[] normals = mesh.normals;
            int[] triangles = mesh.triangles;
            int numOfTriangles = triangles.Length;
            Vector2[] textureCoordinates = mesh.uv;

            if (textureCoordinates.Length < numOfTriangles) // Check if the mesh doesn't have texture coordinates
            {
                textureCoordinates = new Vector2[numOfVertices * 2];
            }

            // Create a new mesh component, double the size of the original
            Vector3[] newVertices = new Vector3[numOfVertices * 2];
            Vector3[] newNormals = new Vector3[numOfVertices * 2];
            int[] newTriangles = new int[numOfTriangles * 2];
            Vector2[] newTextureCoordinates = new Vector2[numOfVertices * 2];

            for (int j = 0; j < numOfVertices; j++)
            {
                newVertices[j] = newVertices[j + numOfVertices] = vertices[j]; // Copy original vertices to make the second half of the new vertices array
                newTextureCoordinates[j] = newTextureCoordinates[j + numOfVertices] = textureCoordinates[j]; // Copy original texture coordinates to make the second half of the new texture coordinates array
                newNormals[j] = normals[j]; // First half of the new normals array is a copy of original normals
                newNormals[j + numOfVertices] = -normals[j]; // Second half of the new normals array reverses the original normals
            }

            for (int x = 0; x < numOfTriangles; x += 3)
            {
                // Copy the original triangle for the first half of the array
                newTriangles[x] = triangles[x];
                newTriangles[x + 1] = triangles[x + 1];
                newTriangles[x + 2] = triangles[x + 2];

                // Reversed triangles for the second half of the array
                int j = x + numOfTriangles;
                newTriangles[j] = triangles[x] + numOfVertices;
                newTriangles[j + 2] = triangles[x + 1] + numOfVertices;
                newTriangles[j + 1] = triangles[x + 2] + numOfVertices;
            }

            mesh.vertices = newVertices;
            mesh.uv = newTextureCoordinates;
            mesh.normals = newNormals;
            mesh.triangles = newTriangles;
        }
    }
}
