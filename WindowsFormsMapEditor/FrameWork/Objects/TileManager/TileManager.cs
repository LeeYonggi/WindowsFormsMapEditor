using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;

using Framework;
using WindowsFormsMapEditor.FrameWork.Objects.Tile;
using Microsoft.DirectX.Direct3D;

public class TileManager : Singleton<TileManager>
{
    private List<Tile> l_tiles = new List<Tile>();
    private List<SelectTile> s_tiles = new List<SelectTile>();
    private string nowSelectTile = null;
    private string nowSelectTileName = null;
    private int size = 0;

    #region Factory Function
    public void Init()
    {
        for(int i = 0; i < 405; i++)
        {
            Tile tile = new Tile();
            tile.Position = new Point((i % 27) * 48, (i / 27) * 48); 
            l_tiles.Add(tile);
        }
        foreach (var iter in l_tiles)
        {
            iter.Init();
        }
    }
    public void SideInit()
    {
        foreach (var iter in s_tiles)
        {
            iter.Init();
        }
    }
    public void Update()
    {
        foreach (var iter in l_tiles)
        {
            iter.Update();
        }
    }
    public void SideUpdate()
    {
        foreach (var iter in s_tiles)
        {
            iter.Update();
        }
    }
    public void Render()
    {
        foreach (var iter in l_tiles)
        {
            iter.Render();
        }
    }
    public void SideRender()
    {
        foreach (var iter in s_tiles)
        {
            iter.Render();
        }
    }
    public void Release()
    {
        foreach (var iter in l_tiles)
        {
            iter.Release();
        }
    }
    #endregion

    public void SetTileScale(Point size)
    {
        foreach (var iter in l_tiles)
        {
            iter.Size = size;
        }
        for (int i = 0; i < 405; i++)
        {
            l_tiles[i].Position = new Point((i % 27) * size.X, (i / 27) * size.Y);
        }
    }
    public void AddSelectTile(Texture tex, string str, string name)
    {
        SelectTile _tile = new SelectTile();
        _tile.Texture = tex;
        _tile.Route = str;
        _tile.Name = name;
        _tile.ChangeSize();
        if(size != 0)
        {
            Point point = s_tiles[size - 1].Position;
            point.Y += s_tiles[size - 1].GetSize.Y;
            _tile.Position = point;
        }
        s_tiles.Add(_tile);
        size++;
    }
    public void SelectTileClick()
    {
        foreach (var iter in s_tiles)
        {
            if (iter.IsCollision(iter.GetSize, iter.GetSubMousePos()))
            {
                nowSelectTile = iter.Route;
                nowSelectTileName = iter.Name;
            }
        }
    }
    public void TileClick()
    {
        foreach(var iter in l_tiles)
        {
            if (iter.IsCollision(iter.Size, iter.GetMousePos()) && nowSelectTile != null)
                iter.SetSpriteTile(nowSelectTile, nowSelectTileName);
        }
    }
    public void DestroyClick()
    {
        foreach (var iter in l_tiles)
        {
            if (iter.IsCollision(iter.Size, iter.GetMousePos()))
                iter.DestroySpriteTile();
        }
    }
    public void SaveFile(string path, StreamWriter streamWriter)
    {
        foreach (var iter in l_tiles)
        {
            iter.SaveSpriteTiles(path, streamWriter);
        }
    }
}