using Xunit;

namespace QueenAttack.Objects
{
  public class Tests
  {

    [Fact]
    public void CheckRows_SeeIfInSameRow_true()
    {
      Move aMove = new Move();
      aMove.SetPosition("c3", "f3");
      aMove.CheckRows();
      Assert.Equal(true, aMove.GetNot());
    }

    [Fact]
    public void CheckCol_SeeIfInSameCol_true()
    {
      Move aMove = new Move();
      aMove.SetPosition("d2", "d8");
      aMove.CheckCol();
      Assert.Equal(true, aMove.GetNot());
    }
  }
}
