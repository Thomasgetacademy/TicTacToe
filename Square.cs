namespace TrePåRad;

public class Square
{
    /* L = letter, N = Number */
    public string L { get; set; }
    public int N { get; set; }
    public string Value { get; set; }
    public Char State { get; set; }

    public Square(string l, int n, string value)
    {
        L = l;
        N = n;
        Value = value;
        State = 'e';
    }
}

//public enum SquareState
//{
//    Empty,
//    X,
//    O
//}

//internal class Square
//{
//    private int _content;

//    public bool IsEmpty()
//    {
//        return _content == 0;
//    }

//    public bool IsPlayer1()
//    {
//        return _content == 1;
//    }

//    
//}