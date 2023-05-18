namespace TrePåRad;

public class Square
{
    /* L = letter, N = Number
     L and N does not get used and this assigment is a bad example of object
    orientated programming because of it.
     */
    public string L { get; set; }
    public int N { get; set; }
    public string Value { get; set; }


    public Square(string l, int n, string value)
    {
        L = l;
        N = n;
        Value = value;
    }
}