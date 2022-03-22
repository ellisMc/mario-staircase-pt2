using System;

class Program {
  public static void Main (string[] args) {
    string steps = "#";
    string space = " ";
    Console.Write("Height:  ");
    int height = get_rows();
    Console.WriteLine(height);
    for(int i = 1; i <= height; i++){
      string finale = "";
      string finale2 = "";
      int x = height - i;
      for(int k = x; k >= 1;k--){
        finale+=space;
      }
      int j = i;
      for(int l = j; j >= 1; j--){
        finale2+=steps;
      }
      Console.WriteLine(finale+finale2+"  "+finale2+finale);
    }
  }

  public static int get_rows(){
    string rows = Console.ReadLine();
    try{
      int n = Convert.ToInt32(rows);
      if(n > 0 && n < 9){
        return n;
      }
      else{
        Console.WriteLine("Invalid input, input must be a integer between 1 - 8");
        n = get_rows();
        return n;
      }
    }
    catch(FormatException){
      Console.WriteLine("Invalid input, input must be a integer between 1 - 8");
      int n = get_rows();
      return n;
    }
  }
}