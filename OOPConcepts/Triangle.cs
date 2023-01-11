class Triange : Shape
{
    public int Hypotenous { get; set; }

    // Poliymorphism
    public override double CalculateArea()  
    {
        return 0.5 * Width * Height;
    }
}