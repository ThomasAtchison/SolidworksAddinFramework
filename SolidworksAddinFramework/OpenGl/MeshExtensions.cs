using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SolidworksAddinFramework.OpenGl
{
    public static class MeshExtensions
    {
        public static Mesh Combine(this IReadOnlyCollection<Mesh> meshes, Color color, bool isSolid)
        {
            var tris = meshes.SelectMany(mesh => mesh.TrianglesWithNormals);
            var edges = meshes.SelectMany(mesh => mesh.Edges).ToList();
            return new Mesh(color, isSolid, tris, edges);
        }
    }
}