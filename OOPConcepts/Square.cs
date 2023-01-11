class Square : Shape
{
    public int Area { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}
