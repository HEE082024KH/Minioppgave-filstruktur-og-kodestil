public class Generic
{
  public Generic generic = new();
  public Generic generic2 = new();
  public string something = "";
  public double s0meth1ng;

  public void GenericStuff()
  {
    Console.WriteLine($"Generic1: {generic} \nGeneric2:{generic2} \nString:{something} \nDouble:{s0meth1ng}");
  }
}