namespace TankDestroyer.API;

public interface IWorld
{
    ITile GetTile(int y, int x);
    int Height { get; set; }
    int Width { get; set; }
}