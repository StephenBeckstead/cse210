using System; 

public class Fraction {
    int _top; 
    int _bottom; 

    public Fraction () {
        _top = 1; 
        _bottom = 1; 
    }

    public Fraction (int wholeNumber) {
        _top = wholeNumber; 
        _bottom = 1; 
    }

    public Fraction (int top, int bottom) {
        _top = top; 
        _bottom = bottom; 
    }

    public string GetFractionString() {
        string s = $"{_top}/{_bottom}";
        return s; 
    }

    public double GetDecimalValue() {
        return _top/ _bottom; 
    }
}