abstract class Shape: IShape                   // abstract key cannot create instance
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }


    public virtual double CalculateArea()
    {
        return Height * Width;  
    }
}
 