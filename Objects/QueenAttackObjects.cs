

namespace QueenAttack.Objects
{
  public class Move
  {
    // properties
    private string _queenMove;
    private string _takeMove;
    private bool _not;
    //Setters
    public void SetPosition(string queenMove, string takeMove)
    {
      _queenMove = queenMove;
      _takeMove = takeMove;
      _not = false;
    }

    public void SetQueenMove(string queenMove)
    {
      _queenMove = queenMove;
    }
    public void SetTakeMove(string takeMove)
    {
      _takeMove = takeMove;
    }
    public void SetNot(bool not)
    {
      _not = not;
    }
    //Getter
    public string GetQueenMove ()
    {
        return _queenMove;
    }
    public string GetTakeMove ()
    {
        return _takeMove;
    }
    public bool GetNot ()
    {
        return _not;
    }
    //Checking Methods
    public void CheckRows ()
    {
      if ( _queenMove[1] == _takeMove[1] )
      {
        _not = true;
      }
    }
    public void CheckCol()
    {
      string qm = _queenMove;
      string tm = _takeMove;
      if( qm[0] == tm[0] )
      {
        _not = true;
      }
    }
    public void CheckDiag()
    {
      string qm = _queenMove;
      string tm = _takeMove;

    }
  }
}
