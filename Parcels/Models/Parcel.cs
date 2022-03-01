using System.Collections.Generic;
using System;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int Weight { get; set; }
    public string Name { get; set; }
    public string To { get; set; }
    public string From { get; set; }
    private static List<Parcel> _instances = new List<Parcel> { };

    public Parcel(int height, int width, int length, int weight, string name, string to, string from)
    {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
      Name = name;
      To = to;
      From = from;
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public int GetVol()
    {
      return this.Height * this.Width * this.Length;
    }
    public int CostCalc()
    {
      return this.GetVol() * 2;
    }
  }
}