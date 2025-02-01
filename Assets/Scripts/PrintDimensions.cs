using Godot;

namespace Chess
{
  // Prints dimensions of a MeshInstance3D at ready
  public partial class PrintDimensions : Node
  {
    public override void _Ready()
    {
      // Get mesh attribute as variant, translate to mesh
      Mesh mesh = (Mesh)Get("mesh");

      // Get mesh aabb, get aabb size, print
      GD.Print(mesh.GetAabb().Size);
    }
  }
}
